using ExactOnline.Client.Models;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.TestContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExactOnline.Client.Sdk.UserAcceptanceTests.UserLevel
{
	[TestClass]
	public class RobustEndpoints
	{
		[TestMethod]
		[TestCategory("User Acceptance Tests")]
		public void TestWithoutDivision()
		{
			var toc = new TestObjectsCreator();
			var client = new ExactOnlineClient(toc.GetWebsite(), toc.GetOAuthAuthenticationToken);
			var accounts = client.For<Account>().Select("Code").Get();
		}

		[TestMethod]
		[TestCategory("User Acceptance Tests")]
		public void TestWithDivision()
		{
			var toc = new TestObjectsCreator();
			var client = new ExactOnlineClient(toc.GetWebsite(), 499156, toc.GetOAuthAuthenticationToken);
			var accounts = client.For<Account>().Select("Code").Get();
		}

		[TestMethod]
		[TestCategory("User Acceptance Tests")]
		public void TestWithSlash()
		{
			var toc = new TestObjectsCreator();
			var client = new ExactOnlineClient(toc.GetWebsite(), 499156, toc.GetOAuthAuthenticationToken);
			var accounts = client.For<Account>().Select("Code").Get();
		}
	}
}
