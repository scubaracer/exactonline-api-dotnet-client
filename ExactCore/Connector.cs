using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ExactCore
{
    public class Connector
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly Uri _callbackUrl;
        private AuthorizationState authorizationState;

        public string EndPoint
        {
            get { return "https://start.exactonline.nl"; }
        }

        public Connector(string clientId, string clientSecret, AuthorizationState authorizationState)
        {
            this._clientId = clientId;
            this._clientSecret = clientSecret;
            this.authorizationState = authorizationState;
        }

        private bool AccessTokenHasToBeRefreshed()
        {
            if (authorizationState.AccessToken == null && authorizationState.RefreshToken != null)
            {
                return true;
            }

            if (authorizationState.AccessTokenExpirationUtc != null)
            {
                TimeSpan timeToExpire = authorizationState.AccessTokenExpirationUtc.Value.Subtract(DateTime.UtcNow);
                return (timeToExpire.Minutes < 1);
            }
            return false;
        }

        public string GetAccessToken()
        {
            if (AccessTokenHasToBeRefreshed())
            {
                using (var client = new HttpClient())
                {
                    var postData = new List<KeyValuePair<string, string>>();
                    postData.Add(new KeyValuePair<string, string>("refresh_token", authorizationState.RefreshToken));
                    postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                    postData.Add(new KeyValuePair<string, string>("client_id", this._clientId));
                    postData.Add(new KeyValuePair<string, string>("client_secret", this._clientSecret));

                    HttpContent content = new FormUrlEncodedContent(postData);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                    var responseResult = client.PostAsync(EndPoint + "/api/oauth2/token", content).Result;

                    dynamic response = Newtonsoft.Json.JsonConvert.DeserializeObject(responseResult.Content.ReadAsStringAsync().Result);
                    if (response.error != null)
                    {
                        var errorDescription = response.error_description;
                        throw new Exception(errorDescription);
                    }
                    else
                    {
                        authorizationState.AccessToken = response.access_token;
                        authorizationState.RefreshToken = response.refresh_token;
                        authorizationState.AccessTokenExpirationUtc = DateTime.UtcNow.AddSeconds(Convert.ToInt32(response.expires_in));
                        return authorizationState.AccessToken;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(authorizationState.AccessToken))
                {
                    return authorizationState.AccessToken;
                }
                else
                {
                    throw new UnauthorizedAccessException("Not authorized to use Exact Online API.");
                }

                //using (var client = new HttpClient())
                //{
                //    var postData = new List<KeyValuePair<string, string>>();
                //    postData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
                //    postData.Add(new KeyValuePair<string, string>("client_id", clientId));
                //    postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));

                //    HttpContent content = new FormUrlEncodedContent(postData);
                //    content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                //    var responseResult = client.PostAsync(EndPoint, content).Result;

                //    dynamic response = responseResult.Content.ReadAsStringAsync().Result;
                //    authorizationState.AccessToken = response.access_token;

                //    return authorizationState.AccessToken;
                //}
            }
            //_authorization.RefreshToken = _refreshToken;
            //UserAuthorizations.Authorize(_authorization, EndPoint, clientId, clientSecret, callbackUrl);

            //_refreshToken = _authorization.AuthorizationState.RefreshToken;
        }

    }
}