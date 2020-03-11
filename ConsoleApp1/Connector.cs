using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExactOnline.Client.OAuth;

namespace ConsoleApp1
{
    public class Connector
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly Uri _callbackUrl;
        public readonly UserAuthorization _authorization;
        private string _refreshToken;
        private string _token;

        public string EndPoint
        {
            get { return "https://start.exactonline.nl"; }
        }

        public string RefreshToken
        {
            get { return _refreshToken; }
        }

        public string Token
        {
            get { return _token; }
        }


        public Connector(string clientId, string clientSecret, Uri callbackUrl, string refreshToken)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _callbackUrl = callbackUrl;
            _authorization = new UserAuthorization();
            _refreshToken = refreshToken;
        }

        public string GetAccessToken()
        {
            _authorization.RefreshToken = _refreshToken;
            UserAuthorizations.Authorize(_authorization, EndPoint, _clientId, _clientSecret, _callbackUrl);

            _refreshToken = _authorization.AuthorizationState.RefreshToken;
            _token = _authorization.AccessToken;
            return _authorization.AccessToken;

        }

    }
}