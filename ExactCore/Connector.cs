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
        //private readonly UserAuthorization _authorization;
        private string _refreshToken;
        private string _token;

        public string Token
        {
            get
            {
                return _token;
            }

            set
            {
                _token = value; 
            }
        }


        public string EndPoint
        {
            get { return "https://start.exactonline.nl"; }
        }

        public string RefreshToken
        {
            get { return _refreshToken; }
        }

        public Connector(string clientId, string clientSecret, Uri callbackUrl, string refreshToken, string token)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _callbackUrl = callbackUrl;
            //_authorization = new UserAuthorization();
            _refreshToken = refreshToken;
            _token = token;
        }

        public string GetAccessToken()
        {
            if (!string.IsNullOrEmpty(_token))
            {
                return _token;
            }
            //_authorization.RefreshToken = _refreshToken;
            //UserAuthorizations.Authorize(_authorization, EndPoint, _clientId, _clientSecret, _callbackUrl);

            //_refreshToken = _authorization.AuthorizationState.RefreshToken;

            //using (var client = new HttpClient())
            //{
            //    var postData = new List<KeyValuePair<string, string>>();
            //    postData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            //    postData.Add(new KeyValuePair<string, string>("client_id", _clientId));
            //    postData.Add(new KeyValuePair<string, string>("client_secret", _clientSecret));

            //    HttpContent content = new FormUrlEncodedContent(postData);
            //    content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            //    var responseResult = client.PostAsync(EndPoint, content).Result;

            //    dynamic response = responseResult.Content.ReadAsStringAsync().Result;
            //}
            using (var client = new HttpClient())
            {
                var postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("refresh_token", _refreshToken));
                postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                postData.Add(new KeyValuePair<string, string>("client_id", _clientId));
                postData.Add(new KeyValuePair<string, string>("client_secret", _clientSecret));

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
                    var accesToken = response.access_token;
                    _refreshToken = response.refresh_token;
                    return accesToken; //_authorization.AccessToken;
                }
            }
        }

    }
}