// <copyright file="Connector.cs" company="crmpartners">
// Copyright (c) crmpartners. All rights reserved.
// </copyright>

namespace ExactCore
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;

    using Newtonsoft.Json;

    /// <summary>
    ///     Class to connect to Exact.
    /// </summary>
    public class Connector
    {
        /// <summary>
        ///     The client id
        /// </summary>
        private readonly string clientId;

        /// <summary>
        ///     The secret
        /// </summary>
        private readonly string clientSecret;

        /// <summary>
        /// The authorization state.
        /// </summary>
        private readonly AuthorizationState authorizationState;

        /// <summary>
        /// Initializes a new instance of the <see cref="Connector"/> class. 
        /// Constructor method
        /// </summary>
        /// <param name="clientId">
        /// Client id
        /// </param>
        /// <param name="clientSecret">
        /// Client secret
        /// </param>
        /// <param name="authorizationState">
        /// State object
        /// </param>
        public Connector(string clientId, string clientSecret, AuthorizationState authorizationState)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.authorizationState = authorizationState;
        }

        /// <summary>
        /// The end point.
        /// </summary>
        public string EndPoint => "https://start.exactonline.nl";

        /// <summary>
        ///     Get the access token or refreshes it.
        /// </summary>
        /// <returns>the access token</returns>
        public string GetAccessToken()
        {
            if (this.AccessTokenHasToBeRefreshed())
            {
                using (var client = new HttpClient())
                {
                    var postData = new List<KeyValuePair<string, string>>();
                    postData.Add(new KeyValuePair<string, string>("refresh_token", this.authorizationState.RefreshToken));
                    postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                    postData.Add(new KeyValuePair<string, string>("client_id", this.clientId));
                    postData.Add(new KeyValuePair<string, string>("client_secret", this.clientSecret));

                    HttpContent content = new FormUrlEncodedContent(postData);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                    var responseResult = client.PostAsync(this.EndPoint + "/api/oauth2/token", content).Result;

                    dynamic response = JsonConvert.DeserializeObject(responseResult.Content.ReadAsStringAsync().Result);
                    if (response.error != null)
                    {
                        var errorDescription = response.error_description;
                        throw new Exception(errorDescription);
                    }

                    this.authorizationState.AccessToken = response.access_token;
                    this.authorizationState.RefreshToken = response.refresh_token;
                    this.authorizationState.AccessTokenExpirationUtc = DateTime.UtcNow.AddSeconds(Convert.ToInt32(response.expires_in));
                    return this.authorizationState.AccessToken;
                }
            }

            if (!string.IsNullOrEmpty(this.authorizationState.AccessToken))
            {
                return this.authorizationState.AccessToken;
            }

            throw new UnauthorizedAccessException("Not authorized to use Exact Online API.");
        }

        /// <summary>
        ///     Checks if the token is still valid or needs to be refreshed.
        /// </summary>
        /// <returns>true or false</returns>
        private bool AccessTokenHasToBeRefreshed()
        {
            if (this.authorizationState.AccessToken == null && this.authorizationState.RefreshToken != null)
            {
                return true;
            }

            if (this.authorizationState.AccessTokenExpirationUtc != null)
            {
                var timeToExpire = this.authorizationState.AccessTokenExpirationUtc.Value.Subtract(DateTime.UtcNow);
                return timeToExpire.Minutes < 1;
            }

            return false;
        }
    }
}