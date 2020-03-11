using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Models.Documents;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.UserAcceptanceTests.UserLevel;
using Newtonsoft.Json;
using Document = ExactOnline.Client.Models.Documents.Document;

namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            //var testApp = new TestApp();

            string refeshToken = null;
            string token = null;
            refeshToken = GetTokensFromFile(refeshToken, ref token);
            try { 

                var connector = new Connector("4bb27c0f-1adf-4a3f-a60e-9938ff301126", "WrtSZyoyFtz0",new Uri("http://localhost"), refeshToken);

                var client = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);
                 
                 var output = JsonConvert.SerializeObject(connector._authorization.AuthorizationState);
                 Console.WriteLine(output);
               // System.IO.File.WriteAllText(@"C:\Test\token.txt", output);

                //var accounts = client.For<Account>().Select("ID","Code", "Created", "Name", "Status").Where("Code+eq+'                24'").Get();
                //var count = accounts.Count;
                //var newAccount = new Account { Name = "test" };

            //    var createdAccount = client.For<Account>().Insert(ref newAccount);

            ////    var accounts = client.For<Account>().Select("ID").Get();
            //    // var client = new ExactOnlineClient(toc.GetWebsite(), toc.GetOAuthAuthenticationToken);
            //    Document document = new Document
            //    {
            //        Subject = "User Acceptance Test Document",
            //        Body = "User Acceptance Test Document",
            //         Category = GetCategoryId(client),
            //        Type = 55, //Miscellaneous
            //        DocumentDate = DateTime.Now.Date
            //    };
            //    bool created = client.For<Document>().Insert(ref document);
            }
            catch (Exception exception)
            {
                var error = exception.Message;
            }
        }

        private static Guid GetCategoryId(ExactOnlineClient client)
        {
            var categories = client.For<DocumentCategory>().Select("ID").Where("Description+eq+'General'").Get();
            var category = categories.First().ID;
            return category;
        }

        private static string GetTokensFromFile(string refeshToken, ref string token)
        {
            try
            {
                string refeshTokenText = File.ReadAllText(@"C:\Test\refreshtoken.txt");
                string tokenText = File.ReadAllText(@"C:\Test\token.txt");

                if (!string.IsNullOrEmpty(refeshTokenText))
                {
                    refeshToken = refeshTokenText;
                }
            }
            catch (Exception exception)
            {
                var error = exception.Message;
            }

            try
            {
                string tokenText = File.ReadAllText(@"C:\Test\token.txt");

                if (!string.IsNullOrEmpty(tokenText))
                {
                    token = tokenText;
                }
            }
            catch (Exception exception)
            {
                var error = exception.Message;
            }

            return refeshToken;
        }
    }


}
