using DotNetOpenAuth.OAuth2;

namespace ExactOnline.Client.OAuth
{
	public class UserAuthorization
	{
        public UserAuthorization()
        {
            AuthorizationState = new AuthorizationState();
        }

		public string AccessToken
		{
			get { return AuthorizationState.AccessToken; }
            set { AuthorizationState.AccessToken = value; }
		}

		public string RefreshToken
        {
            get { return AuthorizationState.RefreshToken; }
            set { AuthorizationState.RefreshToken = value; }
        }

		public IAuthorizationState AuthorizationState { get; set; }
	}
}