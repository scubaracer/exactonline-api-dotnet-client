using System.Collections.Generic;
using System;

namespace CRM
{
    using Newtonsoft.Json;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class AcceptQuotation
    {
        /// <summary>0 = No action (Default), 1 = create sales order, 2 = create sales invoice, 3 = create project.</summary>
        public Int32 Action { get; set; }
        /// <summary>Create a project work breakdown structure. Only needed when ProjectBudgetType = 2.</summary>
        public bool? CreateProjectWBS { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the acception of the quotation.</summary>
        public string ErrorMessage { get; set; }
        /// <summary>The journal in which the sales invoice will be booked. Mandatory for Action = 2.</summary>
        public Int32 InvoiceJournal { get; set; }
        /// <summary>The budget type of the project that will be created. Default = 0.</summary>
        public Int32? ProjectBudgetType { get; set; }
        /// <summary>The code of the project that will be created. Mandatory for Action = 3.</summary>
        public string ProjectCode { get; set; }
        /// <summary>The description of the project that will be created. Mandatory for Action = 3.</summary>
        public string ProjectDescription { get; set; }
        /// <summary>The invoicing date of the project. Mandatory for ProjectInvoicingAction = 2.</summary>
        public DateTime? ProjectInvoiceDate { get; set; }
        /// <summary>The project invoicing action. 0 = None (Default), 1 = Create invoice terms, 2 = As quoted.</summary>
        public Int32? ProjectInvoicingAction { get; set; }
        /// <summary>The prepaid type. Mandatory for ProjectType = 5. 1 = Retainer, 2 = Hour type bundle.</summary>
        public Int32? ProjectPrepaindTypes { get; set; }
        /// <summary>PriceAgreement.</summary>
        public double? ProjectPriceAgreement { get; set; }
        /// <summary>Contains information if the project was successfully created.</summary>
        public string ProjectSuccess { get; set; }
        /// <summary>The type of the project that will be created. 2 = Fixed price (Default), 3 = Time and Material, 4 = Non billable, 5 = Prepaid.</summary>
        public Int32? ProjectType { get; set; }
        /// <summary>Identifier of the quotation.</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Reason why the quotation was accepted.</summary>
        public Guid? ReasonCode { get; set; }
        /// <summary>Contains information if the sales invoice was successfully created.</summary>
        public string SalesInvoiceSuccess { get; set; }
        /// <summary>Contains information if the sales order was successfully created.</summary>
        public string SalesOrderSuccess { get; set; }
        /// <summary>Contains information if the quotation was successfully accepted.</summary>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Account
    {
        /// <summary>Reference to the accountant of the customer. Conditions: The referred accountant must have value &gt; 0 in the field IsAccountant</summary>
        public Guid? Accountant { get; set; }
        /// <summary>ID of the account manager</summary>
        public Guid? AccountManager { get; set; }
        /// <summary>Name of the account manager</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountManagerFullName { get; set; }
        /// <summary>Number of the account manager  </summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? AccountManagerHID { get; set; }
        /// <summary>Reference to Activity sector of the account</summary>
        public Guid? ActivitySector { get; set; }
        /// <summary>Reference to Activity sub-sector of the account</summary>
        public Guid? ActivitySubSector { get; set; }
        /// <summary>Visit address first line</summary>
        public string AddressLine1 { get; set; }
        /// <summary>Visit address second line</summary>
        public string AddressLine2 { get; set; }
        /// <summary>Visit address third line</summary>
        public string AddressLine3 { get; set; }
        /// <summary>Collection of Bank accounts</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<CRM.BankAccount> BankAccounts { get; set; }
        /// <summary>Indicates if the account is blocked</summary>
        public bool? Blocked { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? BRIN { get; set; }
        /// <summary>Reference to the business type of the account</summary>
        public Guid? BusinessType { get; set; }
        /// <summary>Indicates the default for the possibility to drop ship when an item is linked to a supplier</summary>
        public bool? CanDropShip { get; set; }
        /// <summary>Chamber of commerce number</summary>
        public string ChamberOfCommerce { get; set; }
        /// <summary>Visit address City</summary>
        public string City { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Classification { get; set; }
        /// <summary>Account classification 1</summary>
        public Guid? Classification1 { get; set; }
        /// <summary>Account classification 2</summary>
        public Guid? Classification2 { get; set; }
        /// <summary>Account classification 3</summary>
        public Guid? Classification3 { get; set; }
        /// <summary>Account classification 4</summary>
        public Guid? Classification4 { get; set; }
        /// <summary>Account classification 5</summary>
        public Guid? Classification5 { get; set; }
        /// <summary>Account classification 6</summary>
        public Guid? Classification6 { get; set; }
        /// <summary>Account classification 7</summary>
        public Guid? Classification7 { get; set; }
        /// <summary>Account classification 8</summary>
        public Guid? Classification8 { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }
        /// <summary>Unique key, fixed length numeric string with leading spaces, length 18. IMPORTANT: When you use OData $filter on this field you have to make sure the filter parameter contains the leading spaces</summary>
        public string Code { get; set; }
        /// <summary>Code under which your own company is known at the account</summary>
        public string CodeAtSupplier { get; set; }
        /// <summary>Reference to Company size of the account</summary>
        public Guid? CompanySize { get; set; }
        /// <summary>Consolidation scenario (Time &amp; Billing). Values: 0 = No consolidation, 1 = Item, 2 = Item + Project, 3 = Item + Employee, 4 = Item + Employee + Project, 5 = Project + WBS + Item, 6 = Project + WBS + Item + Employee. Item means in this case including Unit and Price, these also have to be the same to consolidate</summary>
        public byte? ConsolidationScenario { get; set; }
        /// <summary>Date of the latest control of account data with external web service</summary>
        public DateTime? ControlledDate { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Costcenter { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte CostPaid { get; set; }
        /// <summary>Country code</summary>
        public string Country { get; set; }
        /// <summary>Country name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Maximum amount of credit for Purchase. If no value has been defined, there is no credit limit</summary>
        public double? CreditLinePurchase { get; set; }
        /// <summary>Maximum amount of credit for sales. If no value has been defined, there is no credit limit</summary>
        public double? CreditLineSales { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Currency { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CustomerSince { get; set; }
        /// <summary>DATEV creditor code for Germany legislation</summary>
        public string DatevCreditorCode { get; set; }
        /// <summary>DATEV debtor code for Germany legislation</summary>
        public string DatevDebtorCode { get; set; }
        /// <summary>Default discount percentage for purchase. This is stored as a fraction. ie 5.5% is stored as .055</summary>
        public double? DiscountPurchase { get; set; }
        /// <summary>Default discount percentage for sales. This is stored as a fraction. ie 5.5% is stored as .055</summary>
        public double? DiscountSales { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Document { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DunsNumber { get; set; }
        /// <summary>E-Mail address of the account</summary>
        public string Email { get; set; }
        /// <summary>Determines in combination with the start date if the account is active. If the current date is &gt; end date the account is inactive</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>RegistrationDate</summary>
        public DateTime? EstablishedDate { get; set; }
        /// <summary>Fax number</summary>
        public string Fax { get; set; }
        /// <summary>Default (corporate) GL offset account for purchase (cost)</summary>
        public Guid? GLAccountPurchase { get; set; }
        /// <summary>Default (corporate) GL offset account for sales (revenue)</summary>
        public Guid? GLAccountSales { get; set; }
        /// <summary>Default GL account for Accounts Payable</summary>
        public Guid? GLAP { get; set; }
        /// <summary>Default GL account for Accounts Receivable</summary>
        public Guid? GLAR { get; set; }
        /// <summary>Indicates whether a customer has withholding tax on sales</summary>
        public bool? HasWithholdingTaxSales { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Suppressed warning message when there is duplication on the DATEV code</summary>
        public bool IgnoreDatevWarningMessage { get; set; }
        /// <summary>Intrastat Area</summary>
        public string IntraStatArea { get; set; }
        /// <summary>Intrastat delivery method</summary>
        public string IntraStatDeliveryTerm { get; set; }
        /// <summary>System for Intrastat</summary>
        public string IntraStatSystem { get; set; }
        /// <summary>Transaction type A for Intrastat</summary>
        public string IntraStatTransactionA { get; set; }
        /// <summary>Transaction type B for Intrastat</summary>
        public string IntraStatTransactionB { get; set; }
        /// <summary>Transport method for Intrastat</summary>
        public string IntraStatTransportMethod { get; set; }
        /// <summary>ID of account to be invoiced instead of this account</summary>
        public Guid? InvoiceAccount { get; set; }
        /// <summary>Code of InvoiceAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountCode { get; set; }
        /// <summary>Name of InvoiceAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountName { get; set; }
        /// <summary>Indicates which attachment types should be sent when a sales invoice is printed. Only values in related table with Invoice=1 are allowed</summary>
        public Int32? InvoiceAttachmentType { get; set; }
        /// <summary>Method of sending for sales invoices. Values: 1: Paper, 2: EMail, 4: Mailbox (electronic exchange)</summary>
        public Int32? InvoicingMethod { get; set; }
        /// <summary>Indicates whether the account is an accountant. Values: 0 = No accountant, 1 = True, but accountant doesn&apos;t want his name to be published in the list of accountants, 2 = True, and accountant is published in the list of accountants</summary>
        public byte IsAccountant { get; set; }
        /// <summary>Indicates whether the accounti is an agency</summary>
        public byte IsAgency { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsBank { get; set; }
        /// <summary>Indicates whether the account is a competitor</summary>
        public byte IsCompetitor { get; set; }
        /// <summary>Indicates whether a customer is eligible for extra duty</summary>
        public bool? IsExtraDuty { get; set; }
        /// <summary>Indicates if the account is excluded from mailing marketing information</summary>
        public byte IsMailing { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMember { get; set; }
        /// <summary>Indicates whether the account is a pilot account</summary>
        public bool? IsPilot { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsPurchase { get; set; }
        /// <summary>Indicates whether the account is a reseller</summary>
        public bool? IsReseller { get; set; }
        /// <summary>Indicates whether the account is allowed for sales</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsSales { get; set; }
        /// <summary>Indicates whether the account is a supplier</summary>
        public bool? IsSupplier { get; set; }
        /// <summary>Language code</summary>
        public string Language { get; set; }
        /// <summary>Language description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LanguageDescription { get; set; }
        /// <summary>Latitude (used by Google maps)</summary>
        public double? Latitude { get; set; }
        /// <summary>Reference to Lead source of an account</summary>
        public Guid? LeadSource { get; set; }
        /// <summary>Bytes of the logo image</summary>
        public byte[] Logo { get; set; }
        /// <summary>The file name (without path, but with extension) of the image</summary>
        public string LogoFileName { get; set; }
        /// <summary>Thumbnail url of the logo</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LogoThumbnailUrl { get; set; }
        /// <summary>Url to retrieve the logo</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LogoUrl { get; set; }
        /// <summary>Longitude (used by Google maps)</summary>
        public double? Longitude { get; set; }
        /// <summary>Reference to main contact person</summary>
        public Guid? MainContact { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Account name</summary>
        public string Name { get; set; }
        /// <summary>Dutch government identification number</summary>
        public string OINNumber { get; set; }
        /// <summary>ID of the parent account</summary>
        public Guid? Parent { get; set; }
        /// <summary>Indicates the loan repayment plan for UK legislation</summary>
        public string PayAsYouEarn { get; set; }
        /// <summary>Code of default payment condition for purchase</summary>
        public string PaymentConditionPurchase { get; set; }
        /// <summary>Description of PaymentConditionPurchase</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionPurchaseDescription { get; set; }
        /// <summary>Code of default payment condition for sales</summary>
        public string PaymentConditionSales { get; set; }
        /// <summary>Description of PaymentConditionSales</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionSalesDescription { get; set; }
        /// <summary>Phone number</summary>
        public string Phone { get; set; }
        /// <summary>Phone number extention</summary>
        public string PhoneExtension { get; set; }
        /// <summary>Visit address postcode</summary>
        public string Postcode { get; set; }
        /// <summary>Default sales price list for account</summary>
        public Guid? PriceList { get; set; }
        /// <summary>Currency of purchase</summary>
        public string PurchaseCurrency { get; set; }
        /// <summary>Description of PurchaseCurrency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseCurrencyDescription { get; set; }
        /// <summary>Indicates number of days required to receive a purchase. Acts as a default</summary>
        public Int32? PurchaseLeadDays { get; set; }
        /// <summary>Default VAT code used for purchase entries</summary>
        public string PurchaseVATCode { get; set; }
        /// <summary>Description of PurchaseVATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseVATCodeDescription { get; set; }
        /// <summary>Define the relation that should be taken in the official document of the rewarding fiscal fiches Belcotax</summary>
        public bool? RecepientOfCommissions { get; set; }
        /// <summary>Remarks</summary>
        public string Remarks { get; set; }
        /// <summary>ID of the reseller account. Conditions: the target account must have the property IsReseller turned on</summary>
        public Guid? Reseller { get; set; }
        /// <summary>Code of Reseller</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ResellerCode { get; set; }
        /// <summary>Name of Reseller</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ResellerName { get; set; }
        /// <summary>Fiscal number for NL legislation</summary>
        public string RSIN { get; set; }
        /// <summary>Currency of Sales used for Time &amp; Billing</summary>
        public string SalesCurrency { get; set; }
        /// <summary>Description of SalesCurrency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesCurrencyDescription { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? SalesTaxSchedule { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTaxScheduleCode { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTaxScheduleDescription { get; set; }
        /// <summary>Default VAT code for a sales entry</summary>
        public string SalesVATCode { get; set; }
        /// <summary>Description of SalesVATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesVATCodeDescription { get; set; }
        /// <summary>Search code</summary>
        public string SearchCode { get; set; }
        /// <summary>Security level (0 - 100)</summary>
        public Int32? SecurityLevel { get; set; }
        /// <summary>Separate invoice per project (Time &amp; Billing)</summary>
        public byte SeparateInvPerProject { get; set; }
        /// <summary>Indicates how invoices are generated from subscriptions. 0 = subscriptions belonging to the same customer are combined in a single invoice. 1 = each subscription results in one invoice. In both cases, each individual subscription line results in one invoice line</summary>
        public byte SeparateInvPerSubscription { get; set; }
        /// <summary>Indicates the number of days it takes to send goods to the customer. Acts as a default</summary>
        public Int32? ShippingLeadDays { get; set; }
        /// <summary>Default shipping method</summary>
        public Guid? ShippingMethod { get; set; }
        /// <summary>Indicates in combination with the end date if the account is active</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>State/Province/County code When changing the Country and the State is filled, the State must be assigned with a valid value from the selected country or set to empty</summary>
        public string State { get; set; }
        /// <summary>Name of State</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StateName { get; set; }
        /// <summary>If the status field is filled this means the account is a customer. The value indicates the customer status. Possible values: A=None, S=Suspect, P=Prospect, C=Customer</summary>
        public string Status { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? StatusSince { get; set; }
        /// <summary>Trade name can be registered and shown with the client (for all legislations)</summary>
        public string TradeName { get; set; }
        /// <summary>Account type: Values: A = Relation, D = Division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Type { get; set; }
        /// <summary>Unique taxpayer reference for UK legislation</summary>
        public string UniqueTaxpayerReference { get; set; }
        /// <summary>Indicates the VAT status of an account to be able to identify the relation that should be selected in the VAT debtor listing in Belgium</summary>
        public string VATLiability { get; set; }
        /// <summary>The number under which the account is known at the Value Added Tax collection agency</summary>
        public string VATNumber { get; set; }
        /// <summary>Website of the account</summary>
        public string Website { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClass
    {
        /// <summary>Classification code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Default credit management scenario to be used for new payment terms</summary>
        public Guid? CreditManagementScenario { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClassification
    {
        /// <summary>Reference to Account classification name</summary>
        public Guid? AccountClassificationName { get; set; }
        /// <summary>Description of AccountClassificationName</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountClassificationNameDescription { get; set; }
        /// <summary>Account classification code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountClassificationName
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Sequence number</summary>
        public Int32 SequenceNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Address
    {
        /// <summary>Account linked to the address</summary>
        public Guid? Account { get; set; }
        /// <summary>Indicates if the account is a supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        /// <summary>Name of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>First address line</summary>
        public string AddressLine1 { get; set; }
        /// <summary>Second address line</summary>
        public string AddressLine2 { get; set; }
        /// <summary>Third address line</summary>
        public string AddressLine3 { get; set; }
        /// <summary>City</summary>
        public string City { get; set; }
        /// <summary>Contact linked to Address</summary>
        public Guid? Contact { get; set; }
        /// <summary>Contact name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ContactName { get; set; }
        /// <summary>Country code</summary>
        public string Country { get; set; }
        /// <summary>Country name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Fax number</summary>
        public string Fax { get; set; }
        /// <summary>Free boolean field 1</summary>
        public bool? FreeBoolField_01 { get; set; }
        /// <summary>Free boolean field 2</summary>
        public bool? FreeBoolField_02 { get; set; }
        /// <summary>Free boolean field 3</summary>
        public bool? FreeBoolField_03 { get; set; }
        /// <summary>Free boolean field 4</summary>
        public bool? FreeBoolField_04 { get; set; }
        /// <summary>Free boolean field 5</summary>
        public bool? FreeBoolField_05 { get; set; }
        /// <summary>Free date field 1</summary>
        public DateTime? FreeDateField_01 { get; set; }
        /// <summary>Free date field 2</summary>
        public DateTime? FreeDateField_02 { get; set; }
        /// <summary>Free date field 3</summary>
        public DateTime? FreeDateField_03 { get; set; }
        /// <summary>Free date field 4</summary>
        public DateTime? FreeDateField_04 { get; set; }
        /// <summary>Free date field 5</summary>
        public DateTime? FreeDateField_05 { get; set; }
        /// <summary>Free number field 1</summary>
        public double? FreeNumberField_01 { get; set; }
        /// <summary>Free number field 2</summary>
        public double? FreeNumberField_02 { get; set; }
        /// <summary>Free number field 3</summary>
        public double? FreeNumberField_03 { get; set; }
        /// <summary>Free number field 4</summary>
        public double? FreeNumberField_04 { get; set; }
        /// <summary>Free number field 5</summary>
        public double? FreeNumberField_05 { get; set; }
        /// <summary>Free text field 1</summary>
        public string FreeTextField_01 { get; set; }
        /// <summary>Free text field 2</summary>
        public string FreeTextField_02 { get; set; }
        /// <summary>Free text field 3</summary>
        public string FreeTextField_03 { get; set; }
        /// <summary>Free text field 4</summary>
        public string FreeTextField_04 { get; set; }
        /// <summary>Free text field 5</summary>
        public string FreeTextField_05 { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Mailbox</summary>
        public string Mailbox { get; set; }
        /// <summary>Indicates if the address is the main address for this type</summary>
        public bool? Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Last 5 digits of SIRET number which is an intern sequential number of 4 digits representing the identification of the localization of the office</summary>
        public string NicNumber { get; set; }
        /// <summary>Notes for an address</summary>
        public string Notes { get; set; }
        /// <summary>Phone number</summary>
        public string Phone { get; set; }
        /// <summary>Phone extension</summary>
        public string PhoneExtension { get; set; }
        /// <summary>Postcode</summary>
        public string Postcode { get; set; }
        /// <summary>State</summary>
        public string State { get; set; }
        /// <summary>Name of the State</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StateDescription { get; set; }
        /// <summary>The type of address. Visit=1, Postal=2, Invoice=3, Delivery=4</summary>
        public Int16? Type { get; set; }
        /// <summary>The warehouse linked to the address, if a warehouse is linked the account will be empty. Can only be filled for type=Delivery</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of the warehoude</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of the warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AddressState
    {
        /// <summary>Country code</summary>
        public string Country { get; set; }
        /// <summary>Description of state prefixed with the code</summary>
        public string DisplayValue { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Latitude</summary>
        public double? Latitude { get; set; }
        /// <summary>Longitude</summary>
        public double? Longitude { get; set; }
        /// <summary>State name</summary>
        public string Name { get; set; }
        /// <summary>State code</summary>
        public string State { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class BankAccount
    {
        /// <summary>Account (customer, supplier) to which the bank account belongs</summary>
        public Guid? Account { get; set; }
        /// <summary>The name of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Bank { get; set; }
        /// <summary>The bank account number</summary>
        [JsonProperty(PropertyName = "bankAccount")]
        public string BankAccountName { get; set; }
        /// <summary>Name of the holder of the bank account, as known by the bank</summary>
        public string BankAccountHolderName { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankDescription { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }
        /// <summary>BIC code of the bank where the bank account is held</summary>
        public string BICCode { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the bank account</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Format that belongs to the bank account number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Format { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string IBAN { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if the bank account is the main bank account</summary>
        public bool? Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>ID of the Payment service account. Used when Type is &apos;P&apos; (Payment service)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? PaymentServiceAccount { get; set; }
        /// <summary>The type indicates what entity the bank account is used for. A = Account (default), E = Employee, K = Cash, P = Payment service, R = Bank, S = Student, U = Unknown. Currently it&apos;s only possible to create &apos;Account&apos; type bank accounts.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Type { get; set; }
        /// <summary>Description of the Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Contact
    {
        /// <summary>The account to which the contact belongs</summary>
        public Guid? Account { get; set; }
        /// <summary>Indicates if account is a customer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool AccountIsCustomer { get; set; }
        /// <summary>Indicates if account is a supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        /// <summary>Reference to the main contact of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? AccountMainContact { get; set; }
        /// <summary>Name of the account</summary>
        public string AccountName { get; set; }
        /// <summary>Second address line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressLine2 { get; set; }
        /// <summary>Street name of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreet { get; set; }
        /// <summary>Street number of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumber { get; set; }
        /// <summary>Street number suffix of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumberSuffix { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? AllowMailing { get; set; }
        /// <summary>Birth date</summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite LastName.</summary>
        public string BirthName { get; set; }
        /// <summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite MiddleName.</summary>
        public string BirthNamePrefix { get; set; }
        /// <summary>Birth place</summary>
        public string BirthPlace { get; set; }
        /// <summary>Email address of the contact</summary>
        public string BusinessEmail { get; set; }
        /// <summary>Fax of the contact</summary>
        public string BusinessFax { get; set; }
        /// <summary>Mobile of the contact</summary>
        public string BusinessMobile { get; set; }
        /// <summary>Phone of the contact</summary>
        public string BusinessPhone { get; set; }
        /// <summary>Phone extension of the contact</summary>
        public string BusinessPhoneExtension { get; set; }
        /// <summary>City</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string City { get; set; }
        /// <summary>Code of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Code { get; set; }
        /// <summary>Country code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Email address of the contact</summary>
        public string Email { get; set; }
        /// <summary>End date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>First name. Provide at least first name or last name to create a new contact</summary>
        public string FirstName { get; set; }
        /// <summary>Full name (First name Middle name Last name)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string FullName { get; set; }
        /// <summary>Gender</summary>
        public string Gender { get; set; }
        /// <summary>Contact ID</summary>
        public Int32? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Identification date</summary>
        public DateTime? IdentificationDate { get; set; }
        /// <summary>Reference to the identification document of the contact</summary>
        public Guid? IdentificationDocument { get; set; }
        /// <summary>Reference to the user responsible for identification</summary>
        public Guid? IdentificationUser { get; set; }
        /// <summary>Initials</summary>
        public string Initials { get; set; }
        /// <summary>Indicates whether contacts are excluded from the marketing list</summary>
        public bool? IsMailingExcluded { get; set; }
        /// <summary>Indicates if this is the main contact of the linked account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMainContact { get; set; }
        /// <summary>Jobtitle of the contact</summary>
        public string JobTitleDescription { get; set; }
        /// <summary>Language code</summary>
        public string Language { get; set; }
        /// <summary>Last name. Provide at least first name or last name to create a new contact</summary>
        public string LastName { get; set; }
        /// <summary>The user should be able to do a full text search on these notes to gather contacts for a marketing campaign</summary>
        public string MarketingNotes { get; set; }
        /// <summary>Middle name</summary>
        public string MiddleName { get; set; }
        /// <summary>Business phone of the contact</summary>
        public string Mobile { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Nationality</summary>
        public string Nationality { get; set; }
        /// <summary>Extra remarks</summary>
        public string Notes { get; set; }
        /// <summary>Last name of partner</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerName { get; set; }
        /// <summary>Middlename of partner</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerNamePrefix { get; set; }
        /// <summary>Reference to the personal information of this contact such as name, gender, address etc.</summary>
        public Guid? Person { get; set; }
        /// <summary>Phone of the contact</summary>
        public string Phone { get; set; }
        /// <summary>Phone extension of the contact</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PhoneExtension { get; set; }
        /// <summary>This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.</summary>
        public byte[] Picture { get; set; }
        /// <summary>Filename of the picture</summary>
        public string PictureName { get; set; }
        /// <summary>Url to retrieve the picture thumbnail</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }
        /// <summary>Url to retrieve the picture</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }
        /// <summary>Postcode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Postcode { get; set; }
        /// <summary>Social security number</summary>
        public string SocialSecurityNumber { get; set; }
        /// <summary>Start date</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>State</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string State { get; set; }
        /// <summary>Title</summary>
        public string Title { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Document
    {
        /// <summary>ID of the related account of this document</summary>
        public Guid? Account { get; set; }
        /// <summary>Attachments linked to the document. Binaries are not sent in the response.</summary>
        public IEnumerable<CRM.DocumentsAttachment> Attachments { get; set; }
        /// <summary>Body of this document</summary>
        public string Body { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Entry date of the incoming document</summary>
        public DateTime? DocumentDate { get; set; }
        /// <summary>Id of document folder</summary>
        public Guid? DocumentFolder { get; set; }
        /// <summary>Url to view the document</summary>
        public string DocumentViewUrl { get; set; }
        /// <summary>Indicates that the document body is empty</summary>
        public bool HasEmptyBody { get; set; }
        /// <summary>Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero</summary>
        public Int32 HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>The opportunity linked to the document</summary>
        public Guid? Opportunity { get; set; }
        /// <summary>Purchase invoice number.</summary>
        public Int32? PurchaseInvoiceNumber { get; set; }
        /// <summary>Purchase order number.</summary>
        public Int32? PurchaseOrderNumber { get; set; }
        /// <summary>&apos;Our reference&apos; of the transaction that belongs to this document</summary>
        public Int32? SalesInvoiceNumber { get; set; }
        /// <summary>Number of the sales order</summary>
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Send Method</summary>
        public Int32? SendMethod { get; set; }
        public Int32 Share { get; set; }
        /// <summary>Subject of this document</summary>
        public string Subject { get; set; }
        /// <summary>The document type</summary>
        public Int32 Type { get; set; }
        /// <summary>Translated description of the document type. $filter and $orderby are not supported for this property.</summary>
        public string TypeDescription { get; set; }
        /// <summary>Translation id of the document type description</summary>
        public Int32 TypeDescriptionTermId { get; set; }
        /// <summary>English description of the document type</summary>
        public string UntermedTypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentsAttachment
    {
        /// <summary>Filename of the attachment</summary>
        public string AttachmentFileName { get; set; }
        /// <summary>File size of the attachment</summary>
        public double AttachmentFileSize { get; set; }
        /// <summary>Url for downloading the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
        public string AttachmentUrl { get; set; }
        public bool CanShowInWebView { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Opportunity
    {
        /// <summary>Lead to which the opportunity applies</summary>
        public Guid? Account { get; set; }
        /// <summary>Accountant linked to the opportunity</summary>
        public Guid? Accountant { get; set; }
        /// <summary>Code of the Accountant</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountantCode { get; set; }
        /// <summary>Name of the Accountant</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountantName { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Indicates the date before/on the NextAction is supposed to be done</summary>
        public DateTime? ActionDate { get; set; }
        /// <summary>Amount in the default currency of the company. AmountDC = AmountFC * RateFC</summary>
        public double? AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double? AmountFC { get; set; }
        /// <summary>Reference to the campaign opportunity is related to</summary>
        public Guid? Campaign { get; set; }
        /// <summary>Description of Campaign</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CampaignDescription { get; set; }
        /// <summary>Reference to the channel opportunity is related to</summary>
        public Int16? Channel { get; set; }
        /// <summary>Description of Channel</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ChannelDescription { get; set; }
        /// <summary>The date when the opportunity is expected to be closed</summary>
        public DateTime? CloseDate { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>The source of the lead/opportunity</summary>
        public Guid? LeadSource { get; set; }
        /// <summary>Description of LeadSource</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LeadSourceDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Name of the opportunity</summary>
        public string Name { get; set; }
        /// <summary>Indicates what follow up action is to be undertaken to move the opportunity towards a deal. Is used in combination with ActionDate</summary>
        public string NextAction { get; set; }
        /// <summary>Notes of the opportunity</summary>
        public string Notes { get; set; }
        /// <summary>The stage of the opportunity. This is a list defined by the user</summary>
        public Guid? OpportunityStage { get; set; }
        /// <summary>Description of OpportunityStage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OpportunityStageDescription { get; set; }
        /// <summary>Status: 1=Open, 2=Closed won, 3=Closed lost</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? OpportunityStatus { get; set; }
        /// <summary>Code of Opportunity Type</summary>
        public Int16? OpportunityType { get; set; }
        /// <summary>Description of Opportunity Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OpportunityTypeDescription { get; set; }
        /// <summary>The resource who owns the opportunity and is responsible to close the opportunity (either won or lost)</summary>
        public Guid? Owner { get; set; }
        /// <summary>Name of Owner</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerFullName { get; set; }
        /// <summary>The chance that the opportunity will be closed and won. The default for the probability depends on the default from the opportunity stage</summary>
        public double? Probability { get; set; }
        /// <summary>Reference to project</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Exchange rate from original to division currency</summary>
        public double? RateFC { get; set; }
        /// <summary>Indicates the reason why the opportunity was lost.</summary>
        public Guid? ReasonCode { get; set; }
        /// <summary>Description of ReasonCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCodeDescription { get; set; }
        /// <summary>Reseller linked to the opportunity</summary>
        public Guid? Reseller { get; set; }
        /// <summary>Code of the Reseller</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ResellerCode { get; set; }
        /// <summary>Name of the Reseller</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ResellerName { get; set; }
        /// <summary>Reference to Sales type</summary>
        public Guid? SalesType { get; set; }
        /// <summary>Description of SalesType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesTypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class OpportunityContact
    {
        /// <summary>The account to which the contact belongs</summary>
        public Guid? Account { get; set; }
        /// <summary>Indicates if account is a customer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool AccountIsCustomer { get; set; }
        /// <summary>Indicates if account is a supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        /// <summary>Reference to the main contact of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? AccountMainContact { get; set; }
        /// <summary>Name of the account</summary>
        public string AccountName { get; set; }
        /// <summary>Second address line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressLine2 { get; set; }
        /// <summary>Street name of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreet { get; set; }
        /// <summary>Street number of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumber { get; set; }
        /// <summary>Street number suffix of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumberSuffix { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? AllowMailing { get; set; }
        /// <summary>Birth date</summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite LastName.</summary>
        public string BirthName { get; set; }
        /// <summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite MiddleName.</summary>
        public string BirthNamePrefix { get; set; }
        /// <summary>Birth place</summary>
        public string BirthPlace { get; set; }
        /// <summary>Email address of the contact</summary>
        public string BusinessEmail { get; set; }
        /// <summary>Fax of the contact</summary>
        public string BusinessFax { get; set; }
        /// <summary>Mobile of the contact</summary>
        public string BusinessMobile { get; set; }
        /// <summary>Phone of the contact</summary>
        public string BusinessPhone { get; set; }
        /// <summary>Phone extension of the contact</summary>
        public string BusinessPhoneExtension { get; set; }
        /// <summary>City</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string City { get; set; }
        /// <summary>Code of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Code { get; set; }
        /// <summary>Contact person that is linked to the opportunity</summary>
        public Guid? Contact { get; set; }
        /// <summary>Country code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Email address of the contact</summary>
        public string Email { get; set; }
        /// <summary>End date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>First name. Provide at least first name or last name to create a new contact</summary>
        public string FirstName { get; set; }
        /// <summary>Full name (First name Middle name Last name)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string FullName { get; set; }
        /// <summary>Gender</summary>
        public string Gender { get; set; }
        /// <summary>Contact ID</summary>
        public Int32? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Identification date</summary>
        public DateTime? IdentificationDate { get; set; }
        /// <summary>Reference to the identification document of the contact</summary>
        public Guid? IdentificationDocument { get; set; }
        /// <summary>Reference to the user responsible for identification</summary>
        public Guid? IdentificationUser { get; set; }
        /// <summary>Initials</summary>
        public string Initials { get; set; }
        /// <summary>Indicates whether contacts are excluded from the marketing list</summary>
        public bool? IsMailingExcluded { get; set; }
        /// <summary>Indicates if this is the main contact of the linked account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsMainContact { get; set; }
        /// <summary>Jobtitle of the contact</summary>
        public string JobTitleDescription { get; set; }
        /// <summary>Language code</summary>
        public string Language { get; set; }
        /// <summary>Last name. Provide at least first name or last name to create a new contact</summary>
        public string LastName { get; set; }
        /// <summary>The user should be able to do a full text search on these notes to gather contacts for a marketing campaign</summary>
        public string MarketingNotes { get; set; }
        /// <summary>Middle name</summary>
        public string MiddleName { get; set; }
        /// <summary>Business phone of the contact</summary>
        public string Mobile { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Nationality</summary>
        public string Nationality { get; set; }
        /// <summary>Extra remarks</summary>
        public string Notes { get; set; }
        /// <summary>Opportunity that is linked to the contact person</summary>
        public Guid? Opportunity { get; set; }
        /// <summary>Last name of partner</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerName { get; set; }
        /// <summary>Middlename of partner</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartnerNamePrefix { get; set; }
        /// <summary>Reference to the personal information of this contact such as name, gender, address etc.</summary>
        public Guid? Person { get; set; }
        /// <summary>Phone of the contact</summary>
        public string Phone { get; set; }
        /// <summary>Phone extension of the contact</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PhoneExtension { get; set; }
        /// <summary>This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.</summary>
        public byte[] Picture { get; set; }
        /// <summary>Filename of the picture</summary>
        public string PictureName { get; set; }
        /// <summary>Url to retrieve the picture thumbnail</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }
        /// <summary>Url to retrieve the picture</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }
        /// <summary>Postcode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Postcode { get; set; }
        /// <summary>Social security number</summary>
        public string SocialSecurityNumber { get; set; }
        /// <summary>Start date</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>State</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string State { get; set; }
        /// <summary>Title</summary>
        public string Title { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class PrintQuotation
    {
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Contains the id of the document that was created</summary>
        public Guid? Document { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the document</summary>
        public string DocumentCreationError { get; set; }
        /// <summary>Contains information if a document was successfully created</summary>
        public string DocumentCreationSuccess { get; set; }
        /// <summary>Based on this layout a PDF is created and attached to an Exact Online document and an email. In case it is not specified, the default layout is used.</summary>
        public Guid? DocumentLayout { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the Email</summary>
        public string EmailCreationError { get; set; }
        /// <summary>Based on this layout the email text is produced. In case it is not specified, the default layout is used.</summary>
        public Guid? EmailLayout { get; set; }
        /// <summary>Extra text that can be added to the printed document and email</summary>
        public string ExtraText { get; set; }
        /// <summary>Date of the quotation printed</summary>
        public DateTime QuotationDate { get; set; }
        /// <summary>Identifier of the quotation</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Set to True if an email containing the quotation should be sent to the customer</summary>
        public bool SendEmailToCustomer { get; set; }
        /// <summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
        public string SenderEmailAddress { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("QuotationID")]
    public class Quotation
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }
        /// <summary>Date on which the customer accepted or rejected the quotation version</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CloseDate { get; set; }
        /// <summary>Date on which you expect to close/win the deal</summary>
        public DateTime? ClosingDate { get; set; }
        /// <summary>Date and time on which the quotation was created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>The currency of the quotation</summary>
        public string Currency { get; set; }
        /// <summary>The account where the items should delivered</summary>
        public Guid? DeliveryAccount { get; set; }
        /// <summary>The code of the delivery account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }
        /// <summary>The contact person of the delivery account</summary>
        public Guid? DeliveryAccountContact { get; set; }
        /// <summary>Full name of the delivery account contact person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountContactFullName { get; set; }
        /// <summary>The name of the delivery account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }
        /// <summary>The id of the delivery address</summary>
        public Guid? DeliveryAddress { get; set; }
        /// <summary>The description of the quotation</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document linked to the quotation</summary>
        public Guid? Document { get; set; }
        /// <summary>The subject of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Date after which the quotation is no longer valid</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>The account to which the invoice is sent</summary>
        public Guid? InvoiceAccount { get; set; }
        /// <summary>The code of the invoice account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountCode { get; set; }
        /// <summary>The contact person of the invoice account</summary>
        public Guid? InvoiceAccountContact { get; set; }
        /// <summary>Full name of the invoice account contact person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountContactFullName { get; set; }
        /// <summary>The name of the invoice account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountName { get; set; }
        /// <summary>Date and time on which the quotation was last modified</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of the modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Opportunity linked to the quotation</summary>
        public Guid? Opportunity { get; set; }
        /// <summary>The name of the opportunity</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OpportunityName { get; set; }
        /// <summary>The account that requested the quotation</summary>
        public Guid? OrderAccount { get; set; }
        /// <summary>The code of the order account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderAccountCode { get; set; }
        /// <summary>The contact person of the order account</summary>
        public Guid? OrderAccountContact { get; set; }
        /// <summary>Full name of the order account contact person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderAccountContactFullName { get; set; }
        /// <summary>The name of the order account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderAccountName { get; set; }
        /// <summary>The project linked to the quotation</summary>
        public Guid? Project { get; set; }
        /// <summary>The code of the project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>The description of the project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Date on which the quotation version is entered or printed. Both during entering and printing this date can be adjusted</summary>
        public DateTime? QuotationDate { get; set; }
        /// <summary>Identifier of the quotation</summary>
        public Guid QuotationID { get; set; }
        /// <summary>The collection of quotation lines</summary>
        public IEnumerable<CRM.QuotationLine> QuotationLines { get; set; }
        /// <summary>Unique number to indentify the quotation. By default this number is based on the setting for first available number</summary>
        public Int32 QuotationNumber { get; set; }
        /// <summary>Extra text that can be added to the quotation</summary>
        public string Remarks { get; set; }
        /// <summary>The user that is responsible for the quotation version</summary>
        public Guid? SalesPerson { get; set; }
        /// <summary>Full name of the sales person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesPersonFullName { get; set; }
        /// <summary>The status of the quotation version. 5 = Rejected, 6 = Reviewed and closed, 10 = Recovery, 20 = Draft, 25 = Open, 35 = Processing... , 40 = Printed, 50 = Accepted</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Status { get; set; }
        /// <summary>The description of the status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Total VAT amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }
        /// <summary>Number indicating the different reviews which are made for the quotation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 VersionNumber { get; set; }
        /// <summary>The number by which this quotation is identified by the order account</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class QuotationLine
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }
        /// <summary>By default this contains the item description</summary>
        public string Description { get; set; }
        /// <summary>Discount given on the default price. This is stored as a fraction. ie 5.5% is stored as .055</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to the item that is sold in this quotation line</summary>
        public Guid? Item { get; set; }
        /// <summary>Description of the item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Indicates the sequence of the lines within one quotation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        /// <summary>Net price of the quotation line</summary>
        public double? NetPrice { get; set; }
        /// <summary>Extra notes</summary>
        public string Notes { get; set; }
        /// <summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
        public double? Quantity { get; set; }
        /// <summary>Identifies the quotation. All the lines of a quotation have the same QuotationID</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Unique number to indentify the quotation. By default this number is based on the setting for first available number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 QuotationNumber { get; set; }
        /// <summary>Code of the item unit</summary>
        public string UnitCode { get; set; }
        /// <summary>Description of the item unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Price per item unit</summary>
        public double? UnitPrice { get; set; }
        /// <summary>VAT amount of the line in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }
        /// <summary>The VAT code that is used when the quotation is invoiced</summary>
        public string VATCode { get; set; }
        /// <summary>Description of the VAT code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }
        /// <summary>The VAT percentage of the VAT code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATPercentage { get; set; }
        /// <summary>Number indicating the different reviews which are made for the quotation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 VersionNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReasonCode
    {
        /// <summary>Indicates if the reason code is active.</summary>
        public byte? Active { get; set; }
        /// <summary>Code of the reason.</summary>
        public string Code { get; set; }
        /// <summary>Creation date.</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator.</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Description of the reason code.</summary>
        public string Description { get; set; }
        /// <summary>Division code.</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key.</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date.</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier.</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier.</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Extra notes.</summary>
        public string Notes { get; set; }
        /// <summary>Type of the reason code.</summary>
        public Int16? Type { get; set; }
        /// <summary>Description of the type of the reason code.</summary>
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class RejectQuotation
    {
        /// <summary>Division code.</summary>
        public Int32 Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the rejection of the quotation.</summary>
        public string ErrorMessage { get; set; }
        /// <summary>Identifier of the quotation.</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Reason why the quotation was rejected.</summary>
        public Guid? ReasonCode { get; set; }
        /// <summary>Contains information if the quotation was successfully rejected.</summary>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class ReopenQuotation
    {
        /// <summary>Division code.</summary>
        public Int32 Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the reopening of the quotation.</summary>
        public string ErrorMessage { get; set; }
        /// <summary>Identifier of the quotation.</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Contains information if the quotation was successfully reopened.</summary>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class ReviewQuotation
    {
        /// <summary>Indicates if the item prices should be copied from the original quotation or the default item prices should be used.</summary>
        public bool? CopyItemPrices { get; set; }
        /// <summary>The description of the new quotation.</summary>
        public string Description { get; set; }
        /// <summary>Division code.</summary>
        public Int32 Division { get; set; }
        /// <summary>The document linked to the new quotation.</summary>
        public Guid? Document { get; set; }
        /// <summary>Contains the error message if an error occurred during the reviewing of the quotation.</summary>
        public string ErrorMessage { get; set; }
        /// <summary>Identifier of the newly created quotation.</summary>
        public Guid? NewQuotationID { get; set; }
        /// <summary>The account who made the order.</summary>
        public Guid? OrderAccount { get; set; }
        /// <summary>The contact person of the account who made the order.</summary>
        public Guid? OrderAccountContact { get; set; }
        /// <summary>The paymentcondition linked to the new quotation.</summary>
        public string PaymentCondition { get; set; }
        /// <summary>The date of the new quotation.</summary>
        public DateTime? QuotationDate { get; set; }
        /// <summary>Identifier of the quotation.</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Contains information if the quotation was successfully reviewed.</summary>
        public string SuccessMessage { get; set; }
    }
}
