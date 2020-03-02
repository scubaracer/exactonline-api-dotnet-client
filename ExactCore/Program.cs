// <copyright file="Program.cs" company="crmpartners">
// Copyright (c) crmpartners. All rights reserved.
// </copyright>

namespace ExactCore
{
    using System;
    using System.IO;
    using System.Linq;

    using ExactOnline.Client.Models.CRM;
    using ExactOnline.Client.Models.Documents;
    using ExactOnline.Client.Sdk.Controllers;

    using Newtonsoft.Json;

    using Document = ExactOnline.Client.Models.Documents.Document;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The get category id.
        /// </summary>
        /// <param name="client">
        ///     The client.
        /// </param>
        /// <returns>
        ///     The <see cref="Guid" />.
        /// </returns>
        private static Guid GetCategoryId(ExactOnlineClient client)
        {
            var categories = client.For<DocumentCategory>().Select("ID").Where("Description+eq+'General'").Get();
            var category = categories.First().ID;
            return category;
        }

        /// <summary>
        ///     The get tokens from file.
        /// </summary>
        /// <returns>
        ///     The <see cref="AuthorizationState" />.
        /// </returns>
        private static AuthorizationState GetTokensFromFile()
        {
            try
            {
                //var tokenText = KeyVaultHelper.GetKeyVaultSecret("ExactCredentials");

                //KeyVaultHelper.SetKeyVaultSecret("ThisIsASecret", "hello world");
                //https://kvdaniel.vault.azure.net/
                var tokenText = File.ReadAllText(@"C:\Test\token.txt");

                if (!string.IsNullOrEmpty(tokenText))
                {
                    return JsonConvert.DeserializeObject<AuthorizationState>(tokenText);
                }
            }
            catch (Exception exception)
            {
                var unused = exception.Message;
            }

            return null;
        }

        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            var authorizationState = GetTokensFromFile();

            var connector = new Connector("4bb27c0f-1adf-4a3f-a60e-9938ff301126", "WrtSZyoyFtz0", authorizationState);

            var client = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);

            var accounts = client.For<Account>().Select("ID", "Created", "Name").Get();
            var count = accounts.Count;

            var document = new Document
            {
               Subject = "User Acceptance Test Document",
               Body = "User Acceptance Test Document",
               Category = GetCategoryId(client),
               Type = 55, // Miscellaneous
               DocumentDate = DateTime.Now.Date
            };
            var created = client.For<Document>().Insert(ref document);

            Account a;

            // a.Created
            // a.Name
            Console.WriteLine("Hello World!");
        }
    }
}