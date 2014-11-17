using System;
using DotNetOpenAuth.OAuth2;
using DotNetOpenAuth.Messaging;

namespace ExactOnline.Client.OAuth
{
	public class OAuthClient : UserAgentClient
	{
		private readonly Uri _redirectUri;

		#region Constructor

		public OAuthClient(AuthorizationServerDescription serverDescription, string clientId, string clientSecret, Uri redirectUri)
			: base(serverDescription, clientId, clientSecret)
		{
			_redirectUri = redirectUri;
			ClientCredentialApplicator = ClientCredentialApplicator.PostParameter(clientSecret);
		}

		#endregion

		#region Public methods

		public void Authorize(ref IAuthorizationState authorization, string refreshToken)
		{
			if ((authorization == null))
			{
				authorization = new AuthorizationState
				{
					Callback = _redirectUri,
					RefreshToken = refreshToken
				};
			}

			bool refreshFailed = false;
			if (AccessTokenHasToBeRefreshed(authorization))
			{
				try
				{
					refreshFailed = !RefreshAuthorization(authorization);
				}
				catch (ProtocolException)
				{
					//The refreshtoken is not valid anymore
				}
			}

			if (authorization.AccessToken == null || refreshFailed)
			{
				using (var loginDialog = new LoginForm(_redirectUri))
				{
					Uri url = RequestUserAuthorization(authorization);

					var urlBuilder = new UriBuilder(url) {Query = url.Query.Substring(1)};
					loginDialog.AuthorizationUri = urlBuilder.Uri;

					loginDialog.ShowDialog();

					ProcessUserAuthorization(loginDialog.AuthorizationUri, authorization);
				}
			}
		}

		#endregion

		#region Private methods

		private static bool AccessTokenHasToBeRefreshed(IAuthorizationState authorization)
		{
			if (authorization.AccessToken == null && authorization.RefreshToken != null)
			{
				return true;
			}

			if (authorization.AccessTokenExpirationUtc != null)
			{
				TimeSpan timeToExpire = authorization.AccessTokenExpirationUtc.Value.Subtract(DateTime.UtcNow);
				return (timeToExpire.Minutes < 1);
			}
			return false;
		}

		#endregion

	}

}