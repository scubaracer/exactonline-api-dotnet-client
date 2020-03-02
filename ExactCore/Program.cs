// <copyright file="Program.cs" company="crmpartners">
// Copyright (c) crmpartners. All rights reserved.
// </copyright>

namespace ExactCore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Json;

    using ExactOnline.Client.Models.CRM;
    using ExactOnline.Client.Models.Documents;
    using ExactOnline.Client.Models.SalesInvoice;
    using ExactOnline.Client.Sdk.Controllers;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using Document = ExactOnline.Client.Models.Documents.Document;

    public class ResX
    {
        public string Key { get; set; }
        public object? Value { get; set; }
    }
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
        /// <remarks>
        /// Oke, het zou eigenlijk gaan om drie lijnen. H
        /// 1)	Het aanmaken van een account van CE naar Exact(éénrichting)
        /// 2)	Het aanmaken van een factuurregel/factuurrecord van CE naar Exact(eenrichting)
        /// 3)	Het terugkoppelen van een status(betaald/niet betaald) van een factuur van Exact naar CE(éénrichting)
        /// </remarks>
        /// </summary>
        private static void Main()
        {

            var json = @"{
    ""d"": {
        ""__metadata"": {
            ""uri"": ""https://start.exactonline.nl/api/v1/2699429/crm/Accounts(guid'75129ad8-a526-4af4-b2d6-03deecf0d333')"",
            ""type"": ""Exact.Web.Api.Models.Account""
        },
        ""Accountant"": null,
        ""BankAccounts"": {
            ""__deferred"": {
                ""uri"": ""https://start.exactonline.nl/api/v1/2699429/crm/Accounts(guid'75129ad8-a526-4af4-b2d6-03deecf0d333')/BankAccounts""
            }
        },
        ""Blocked"": null,
        ""BRIN"": null,
        ""BSN"": null,
        ""BusinessType"": null,
        ""CanDropShip"": null,
        ""ChamberOfCommerce"": null,
        ""City"": null,
        ""Classification"": null,
        ""Classification1"": null,
        ""Classification2"": null,
        ""Classification3"": null,
        ""Classification4"": null,
        ""Classification5"": null,
        ""Classification6"": null,
        ""Classification7"": null,
        ""Classification8"": null,
        ""ClassificationDescription"": null,
        ""Code"": null,
        ""CodeAtSupplier"": null,
        ""CompanySize"": null,
        ""ConsolidationScenario"": null,
        ""ControlledDate"": null,
        ""Costcenter"": null,
        ""CostcenterDescription"": null,
        ""CostPaid"": 0,
        ""Country"": null,
        ""CountryName"": null,
        ""Created"": null,
        ""Creator"": null,
        ""CreatorFullName"": null,
        ""CreditLinePurchase"": null,
        ""CreditLineSales"": null,
        ""Currency"": null,
        ""CustomerSince"": null,
        ""DatevCreditorCode"": null,
        ""DatevDebtorCode"": null,
        ""DiscountPurchase"": null,
        ""DiscountSales"": null,
        ""Division"": null,
        ""Document"": null,
        ""DunsNumber"": null,
        ""Email"": null,
        ""EndDate"": null,
        ""EstablishedDate"": null,
        ""Fax"": null,
        ""GLAccountPurchase"": null,
        ""GLAccountSales"": null,
        ""GLAP"": null,
        ""GLAR"": null,
        ""GlnNumber"": null,
        ""HasWithholdingTaxSales"": null,
        ""ID"": ""75129ad8-a526-4af4-b2d6-03deecf0d333"",
        ""IgnoreDatevWarningMessage"": false,
        ""IntraStatArea"": null,
        ""IntraStatDeliveryTerm"": null,
        ""IntraStatSystem"": null,
        ""IntraStatTransactionA"": null,
        ""IntraStatTransactionB"": null,
        ""IntraStatTransportMethod"": null,
        ""InvoiceAccount"": null,
        ""InvoiceAccountCode"": null,
        ""InvoiceAccountName"": null,
        ""InvoiceAttachmentType"": null,
        ""InvoicingMethod"": null,
        ""IsAccountant"": 0,
        ""IsAgency"": 0,
        ""IsAnonymised"": 0,
        ""IsBank"": null,
        ""IsCompetitor"": 0,
        ""IsExtraDuty"": null,
        ""IsMailing"": 0,
        ""IsMember"": null,
        ""IsPilot"": null,
        ""IsPurchase"": null,
        ""IsReseller"": null,
        ""IsSales"": null,
        ""IsSupplier"": null,
        ""Language"": null,
        ""LanguageDescription"": null,
        ""Latitude"": null,
        ""LeadSource"": null,
        ""LeadPurpose"": null,
        ""LogoFileName"": null,
        ""LogoThumbnailUrl"": null,
        ""LogoUrl"": null,
        ""Logo"": null,
        ""Longitude"": null,
        ""MainContact"": null,
        ""Modified"": null,
        ""Modifier"": null,
        ""ModifierFullName"": null,
        ""Name"": null,
        ""OINNumber"": null,
        ""Parent"": null,
        ""PaymentConditionPurchase"": null,
        ""PaymentConditionPurchaseDescription"": null,
        ""PaymentConditionSales"": null,
        ""PaymentConditionSalesDescription"": null,
        ""PayAsYouEarn"": null,
        ""Phone"": null,
        ""PhoneExtension"": null,
        ""Postcode"": null,
        ""PriceList"": null,
        ""PurchaseCurrency"": null,
        ""PurchaseCurrencyDescription"": null,
        ""PurchaseLeadDays"": null,
        ""PurchaseVATCode"": null,
        ""PurchaseVATCodeDescription"": null,
        ""Remarks"": null,
        ""RecepientOfCommissions"": null,
        ""Reseller"": null,
        ""ResellerCode"": null,
        ""ResellerName"": null,
        ""RSIN"": null,
        ""SalesCurrency"": null,
        ""SalesCurrencyDescription"": null,
        ""SalesVATCode"": null,
        ""SalesVATCodeDescription"": null,
        ""SearchCode"": null,
        ""SecurityLevel"": null,
        ""SeparateInvPerProject"": 0,
        ""SeparateInvPerSubscription"": 0,
        ""ShippingLeadDays"": null,
        ""ShippingMethod"": null,
        ""StartDate"": null,
        ""State"": null,
        ""StateName"": null,
        ""Status"": null,
        ""StatusSince"": null,
        ""SalesTaxSchedule"": null,
        ""SalesTaxScheduleCode"": null,
        ""SalesTaxScheduleDescription"": null,
        ""TradeName"": null,
        ""Type"": null,
        ""UniqueTaxpayerReference"": null,
        ""VATLiability"": null,
        ""VATNumber"": null,
        ""Website"": null
    }
}";
            //var jobjects = JObject.Parse(json);
            //var d = jobjects["d"];
            //var z = jobjects.SelectTokens("d");

            //var props = new Dictionary<string, object>();
            //foreach (JProperty child in d.Children())
            //{
                
            //    var x = child.Name;
            //    if (!child.Value.ToString().Contains("def"))
            //    {
            //        if (child.Value.Type.ToString() == "Null")
            //        {
            //            props.Add(child.Name, null);
            //        }
            //        else
            //        {
            //            props.Add(child.Name, child.Value.ToString());
            //        }
                    

            //var newJson = JsonConvert.SerializeObject(props);
            
            var authorizationState = GetTokensFromFile();

            var connector = new Connector("4bb27c0f-1adf-4a3f-a60e-9938ff301126", "WrtSZyoyFtz0", authorizationState);

            var client = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);

            //Exact.Web.Api.Models.Account

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

            var newAccount = new Account { Name = "test" };

            var createdAccount = client.For<Account>().Insert(ref newAccount);

            var newInvoice = new SalesInvoice { InvoiceNumber = 1111, InvoiceTo = newAccount.ID };
            var createdInvoice = client.For<SalesInvoice>().Insert(ref newInvoice);

            var newInvoiceLine = new SalesInvoiceLine { GLAccount = newAccount.ID, InvoiceID = newInvoice.InvoiceID };
            var createdInvoiceLine = client.For<SalesInvoiceLine>().Insert(ref newInvoiceLine);

           


            // a.Created
            // a.Name
            Console.WriteLine("Hello World!");
        }
    }
}