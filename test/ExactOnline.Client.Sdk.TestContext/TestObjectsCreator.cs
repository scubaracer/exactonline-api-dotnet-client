using ExactOnline.Client.OAuth;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.Interfaces;
using System;

namespace ExactOnline.Client.Sdk.TestContext
{
	public class TestObjectsCreator
	{
		private const string Website = "https://start.exactonline.nl";

		private readonly static UserAuthorization Authorization = new UserAuthorization();

		private IApiConnector _connector;

		public IApiConnector ApiConnector()
		{
			return _connector ?? (_connector = new ApiConnector(GetOAuthAuthenticationToken));
		}

		public string GetWebsite()
		{
			return Website;
		}

		public string GetOAuthAuthenticationToken()
		{
			var testApp = new TestApp();
			UserAuthorizations.Authorize(Authorization, EndPoint, testApp.ClientId.ToString(), testApp.ClientSecret, testApp.CallbackUrl);

			return Authorization.AccessToken;
		}

		public string EndPoint
		{
			get
			{
				return Website;
			}
		}

		public string UriGlAccount(int currentDivision)
		{
			return String.Format("{0}/api/v1/{1}/financial/GLAccounts", Website, currentDivision);
		}

		public string UriCrmAccount(int currentDivision)
		{
			return String.Format("{0}/api/v1/{1}/crm/Accounts", Website, currentDivision);
		}


		public int GetCurrentDivision()
		{

			var currentDivision = -1;

			if (_connector == null)
			{
				ApiConnector();
			}

			if (_connector != null)
			{
				currentDivision = _connector.GetCurrentDivision(Website);
			}

			return currentDivision;
		}
	}
}
