using System;
using System.IO;
using System.Linq;
using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Models.Documents;
using ExactOnline.Client.Sdk.Controllers;
using Document = ExactOnline.Client.Models.Documents.Document;

namespace ExactCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string refeshToken = null;
            string token = null;
            refeshToken = GetTokensFromFile(refeshToken, ref token);

            var connector = new Connector("xxxx", "xxx", new Uri("http://localhost"), refeshToken, token);

            var client = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);
            System.IO.File.WriteAllText(@"C:\Test\refreshtoken.txt", connector.RefreshToken);
            System.IO.File.WriteAllText(@"C:\Test\token.txt", connector.Token);

            
            var accounts = client.For<Account>().Select("ID", "Created", "Name").Get();

            Document document = new Document
            {
                Subject = "User Acceptance Test Document",
                Body = "User Acceptance Test Document",
                Category = GetCategoryId(client),
                Type = 55, //Miscellaneous
                DocumentDate = DateTime.Now.Date
            };
            bool created = client.For<Document>().Insert(ref document);

            Account a;
            //a.Created
            //a.Name
            Console.WriteLine("Hello World!");
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
