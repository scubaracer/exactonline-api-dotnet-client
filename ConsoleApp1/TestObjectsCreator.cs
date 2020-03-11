
using ExactOnline.Client.OAuth;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.Interfaces;
using System;

namespace ConsoleApp1
{
	public class TestObjectsCreator
	{
		private const string Website = "https://start.exactonline.nl";

		private readonly static UserAuthorization Authorization = new UserAuthorization();

		private IApiConnector _connector;
		private ExactOnlineClient _client;

		public IApiConnector ApiConnector()
		{
			return _connector ?? (_connector = new ApiConnector(GetOAuthAuthenticationToken, GetClient()));
		}

		public string GetWebsite()
		{
			return Website;
		}

		public ExactOnlineClient GetClient()
		{
			return _client ?? (_client = new ExactOnlineClient(GetWebsite(), GetOAuthAuthenticationToken));
		}

		public string GetOAuthAuthenticationToken()
		{
			//var testApp = new TestApp();
			UserAuthorizations.Authorize(Authorization, EndPoint, "4bb27c0f-1adf-4a3f-a60e-9938ff301126", "WrtSZyoyFtz0",  new Uri("http://localhost"));

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
