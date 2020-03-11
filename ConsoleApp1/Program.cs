namespace ExactTokenGeneration
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Linq;

    using ExactOnline.Client.Models.Documents;
    using ExactOnline.Client.Sdk.Controllers;

    using Newtonsoft.Json;

    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        [STAThread]
        static void Main(string[] args)
        {
            string refeshToken = null;
            //string token = null;
            //refeshToken = GetTokensFromFile(refeshToken, ref token);
            try 
            { 
                var connector = new Connector(ConfigurationManager.AppSettings["Clientid"], ConfigurationManager.AppSettings["Secret"], new Uri("http://localhost"), refeshToken);

                var client = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);
                 
                 var output = JsonConvert.SerializeObject(connector._authorization.AuthorizationState);
                 Console.WriteLine(output);
               // System.IO.File.WriteAllText(@"C:\Test\token.txt", output);
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

        //private static string GetTokensFromFile(string refeshToken, ref string token)
        //{
        //    try
        //    {
        //        string refeshTokenText = File.ReadAllText(@"C:\Test\refreshtoken.txt");
        //        string tokenText = File.ReadAllText(@"C:\Test\token.txt");

        //        if (!string.IsNullOrEmpty(refeshTokenText))
        //        {
        //            refeshToken = refeshTokenText;
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        var error = exception.Message;
        //    }

        //    try
        //    {
        //        string tokenText = File.ReadAllText(@"C:\Test\token.txt");

        //        if (!string.IsNullOrEmpty(tokenText))
        //        {
        //            token = tokenText;
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        var error = exception.Message;
        //    }

        //    return refeshToken;
        //}
    }


}
