using System;

namespace Financial
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AgeGroup")]
    public class AgingOverview
    {
        /// <summary>Primary key</summary>
        public Int32 AgeGroup { get; set; }
        /// <summary>Description of AgeGroup</summary>
        public string AgeGroupDescription { get; set; }
        /// <summary>Amount payable</summary>
        public double AmountPayable { get; set; }
        /// <summary>Amount receivable</summary>
        public double AmountReceivable { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class AgingPayablesList
    {
        /// <summary>Code of Account</summary>
        public string AccountCode { get; set; }
        /// <summary>Primary key</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public string AccountName { get; set; }
        /// <summary>Age group 1</summary>
        public Int32 AgeGroup1 { get; set; }
        /// <summary>Amount of age group 1</summary>
        public double AgeGroup1Amount { get; set; }
        /// <summary>Description of AgeGroup1</summary>
        public string AgeGroup1Description { get; set; }
        /// <summary>Age group 2</summary>
        public Int32 AgeGroup2 { get; set; }
        /// <summary>Amount of age group 2</summary>
        public double AgeGroup2Amount { get; set; }
        /// <summary>Description of AgeGroup2</summary>
        public string AgeGroup2Description { get; set; }
        /// <summary>Age group 3</summary>
        public Int32 AgeGroup3 { get; set; }
        /// <summary>Amount of age group 3</summary>
        public double AgeGroup3Amount { get; set; }
        /// <summary>Description of AgeGroup3</summary>
        public string AgeGroup3Description { get; set; }
        /// <summary>Age group 4</summary>
        public Int32 AgeGroup4 { get; set; }
        /// <summary>Amount of age group 4</summary>
        public double AgeGroup4Amount { get; set; }
        /// <summary>Description of AgeGroup4</summary>
        public string AgeGroup4Description { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Total amount of all age groups</summary>
        public double TotalAmount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class AgingReceivablesList
    {
        /// <summary>Code of Account</summary>
        public string AccountCode { get; set; }
        /// <summary>Primary key</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public string AccountName { get; set; }
        /// <summary>Age group 1</summary>
        public Int32 AgeGroup1 { get; set; }
        /// <summary>Amount of age group 1</summary>
        public double AgeGroup1Amount { get; set; }
        /// <summary>Description of AgeGroup1</summary>
        public string AgeGroup1Description { get; set; }
        /// <summary>Age group 2</summary>
        public Int32 AgeGroup2 { get; set; }
        /// <summary>Amount of age group 2</summary>
        public double AgeGroup2Amount { get; set; }
        /// <summary>Description of AgeGroup2</summary>
        public string AgeGroup2Description { get; set; }
        /// <summary>Age group 3</summary>
        public Int32 AgeGroup3 { get; set; }
        /// <summary>Amount of age group 3</summary>
        public double AgeGroup3Amount { get; set; }
        /// <summary>Description of AgeGroup3</summary>
        public string AgeGroup3Description { get; set; }
        /// <summary>Age group 4</summary>
        public Int32 AgeGroup4 { get; set; }
        /// <summary>Amount of age group 4</summary>
        public double AgeGroup4Amount { get; set; }
        /// <summary>Description of AgeGroup4</summary>
        public string AgeGroup4Description { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Total amount of all age groups</summary>
        public double TotalAmount { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ExchangeRate
    {
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
        /// <summary>The exchange rate is stored as 1 TARGET CURRENCY = x SOURCE CURRENCY</summary>
        public double? Rate { get; set; }
        /// <summary>The foreign currency</summary>
        public string SourceCurrency { get; set; }
        /// <summary>Description of SourceCurrency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SourceCurrencyDescription { get; set; }
        /// <summary>The date as of which the rate is valid. The rate is valid until a next rate is defined</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>The default currency of the division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TargetCurrency { get; set; }
        /// <summary>Description of TargetCurrency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TargetCurrencyDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class FinancialPeriod
    {
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
        /// <summary>The end date of the period</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>The financial period. Usually the period is a month or quarter with period 1 starting on the first of January.</summary>
        public Int16? FinPeriod { get; set; }
        /// <summary>The financial year. The financial year and calendar year are not always aligned.</summary>
        public Int16? FinYear { get; set; }
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
        /// <summary>The start date of a period. A start date should always succeed a previous end date. Except for the first year/period combination</summary>
        public DateTime? StartDate { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class GLAccount
    {
        /// <summary>AssimilatedVATBox (France)</summary>
        public Int16? AssimilatedVATBox { get; set; }
        /// <summary>The following values are supported: D (Debit) C (Credit)</summary>
        public string BalanceSide { get; set; }
        /// <summary>The following values are supported: B (Balance Sheet) W (Profit &amp; Loss)</summary>
        public string BalanceType { get; set; }
        /// <summary>Indentify the kind of rewarding for the G/L account. This is used in the official document for the fiscal fiches Belcotax</summary>
        public Int32? BelcotaxType { get; set; }
        /// <summary>Unique Code of the G/L account</summary>
        public string Code { get; set; }
        /// <summary>Indicate if this G/L account should be shown as compressed without the details in the CRW report of G/L history</summary>
        public bool? Compress { get; set; }
        /// <summary>Cost Center linked to the G/L account</summary>
        public string Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        /// <summary>Cost Unit linked to the G/L account</summary>
        public string Costunit { get; set; }
        /// <summary>Description of Costunit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Name of the G/L account</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>General ledger transactions on this G/L account should not appear on the VAT listing</summary>
        public byte ExcludeVATListing { get; set; }
        /// <summary>Expenses on this G/L account can not be used to reduce the incomes</summary>
        public double? ExpenseNonDeductiblePercentage { get; set; }
        /// <summary>Primary Key</summary>
        public Guid ID { get; set; }
        /// <summary>When blocked you can&apos;t use this general ledger account anymore for new entries</summary>
        public bool? IsBlocked { get; set; }
        /// <summary>Allow entries on this general ledger account to be matched via the G/L account card</summary>
        public bool? Matching { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>If a private use percentage is defined, you need to specify the G/L account used for the re-invoice of the private use to the owner of the company</summary>
        public Guid? PrivateGLAccount { get; set; }
        /// <summary>Specify the percentage of the cost that should be re-invoiced to the owner of the company as private use of the costs</summary>
        public double? PrivatePercentage { get; set; }
        /// <summary>Used in the export of yearly report</summary>
        public string ReportingCode { get; set; }
        /// <summary>Indicates if the amounts booked on this general ledger account will be recalculated when currency revaluation is done</summary>
        public bool? RevalueCurrency { get; set; }
        /// <summary>Search Code</summary>
        public string SearchCode { get; set; }
        /// <summary>The type of the G/L account. Supported values are:&lt;br&gt;10 = Cash&lt;br&gt;12 = Bank&lt;br&gt;14 = Credit card&lt;br&gt;16 = Payment services&lt;br&gt;20 = Accounts receivable&lt;br&gt;21 = Prepayment accounts receivable&lt;br&gt;22 = Accounts payable&lt;br&gt;24 = VAT&lt;br&gt;25 = Employees payable&lt;br&gt;26 = Prepaid expenses&lt;br&gt;27 = Accrued expenses&lt;br&gt;29 = Income taxes payable&lt;br&gt;30 = Fixed assets&lt;br&gt;32 = Other assets&lt;br&gt;35 = Accumulated depreciation&lt;br&gt;40 = Inventory&lt;br&gt;50 = Capital stock&lt;br&gt;52 = Retained earnings&lt;br&gt;55 = Long term debt&lt;br&gt;60 = Current portion of debt&lt;br&gt;90 = General&lt;br&gt;100 = Tax payable&lt;br&gt;110 = Revenue&lt;br&gt;111 = Cost of goods&lt;br&gt;120 = Other costs&lt;br&gt;121 = Sales, general administrative expenses&lt;br&gt;122 = Depreciation costs&lt;br&gt;123 = Research and development&lt;br&gt;125 = Employee costs&lt;br&gt;126 = Employment costs&lt;br&gt;130 = Exceptional costs&lt;br&gt;140 = Exceptional income&lt;br&gt;150 = Income taxes&lt;br&gt;160 = Interest income&lt;br&gt;300 = Year end reflection&lt;br&gt;301 = Indirect year end costing&lt;br&gt;302 = Direct year end costing&lt;br&gt;</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>Indicates if cost centers can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)</summary>
        public byte? UseCostcenter { get; set; }
        /// <summary>Indicates if cost units can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)</summary>
        public byte? UseCostunit { get; set; }
        /// <summary>VAT Code linked to the G/L account</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VAT</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }
        /// <summary>Specify the kind of purchase this G/L account is used for. This is important for the Belgian VAT return to indicate in which VAT box the base amount of purchase should go</summary>
        public string VATGLAccountType { get; set; }
        /// <summary>If you use a percentage of non deductible VAT, you can specify another G/L account that will be used for the non deductible part of the VAT amount. This is used directly in the entry application of purchase invoices.</summary>
        public Guid? VATNonDeductibleGLAccount { get; set; }
        /// <summary>If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices</summary>
        public double? VATNonDeductiblePercentage { get; set; }
        /// <summary>The following values are supported: I (Invoice) C (Cash) (France)</summary>
        public string VATSystem { get; set; }
        /// <summary>Indicates the costing account for year end calculations</summary>
        public Guid? YearEndCostGLAccount { get; set; }
        /// <summary>Indicates the reflection account that is used by year end application</summary>
        public Guid? YearEndReflectionGLAccount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLClassification
    {
        /// <summary>Abstract elements are only used in presentation linkbases to group other elements. They are not supposed to be used in instance documents</summary>
        public bool? Abstract { get; set; }
        /// <summary>Only used for amount concepts: in that case either &apos;debit&apos; or &apos;credit&apos;</summary>
        public string Balance { get; set; }
        /// <summary>The Code is unique</summary>
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
        /// <summary>Description of the element. Note that this description is only used for division-specific taxonomies (or reporting schemes). For general taxonomies, the descriptions are stored in the TaxonomyLabels table</summary>
        public string Description { get; set; }
        /// <summary>Division is optional. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Obsolete</summary>
        public bool? IsTupleSubElement { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>The Name is unique in the namespace</summary>
        public string Name { get; set; }
        /// <summary>Determines whether usage of the element is mandatory in an instance document</summary>
        public bool? Nillable { get; set; }
        /// <summary>Parent element for reporting schemes. In a reporting scheme, an element can have only one parent. This column is only used for reporting schemes. Note that in a real taxonomy, elements can have multiple parents.</summary>
        public Guid? Parent { get; set; }
        /// <summary>Only used for item concepts: either &apos;instant&apos; or &apos;duration&apos;. &apos;instant&apos; is used for balance types of concepts, &apos;duration&apos; is used for P&amp;L types of concepts</summary>
        public string PeriodType { get; set; }
        /// <summary>Mostly import sutstitutiongroup is xbrli:tuple, which makes the element a tuple concept. The default substitutiongroup for item concepts is xbrli:item</summary>
        public string SubstitutionGroup { get; set; }
        /// <summary>Namespace of the element</summary>
        public Guid? TaxonomyNamespace { get; set; }
        /// <summary>Description of TaxonomyNamespace</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxonomyNamespaceDescription { get; set; }
        /// <summary>Type of the element</summary>
        public Guid? Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLScheme
    {
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
        /// <summary>Description text</summary>
        public string Description { get; set; }
        /// <summary>Division is optional for this table. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Only used for reporting schemes = division specific taxonomynamespaces. In this case, main = 1 denotes the main or default reporting scheme</summary>
        public byte Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>URI, which is the unique identifier of the namespace</summary>
        public string TargetNamespace { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLTransactionType
    {
        public string Description { get; set; }
        public string DescriptionSuffix { get; set; }
        public Int32 ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Journal
    {
        /// <summary>Indicates if the journal allows variable currency</summary>
        public bool? AllowVariableCurrency { get; set; }
        /// <summary>Indicates if the journal allows the exchange rate of the currency of the amounts in the journal entry to be changed</summary>
        public bool? AllowVariableExchangeRate { get; set; }
        /// <summary>Indicates if the journal allows the use of VAT in the financial entry. Especially true for general journals</summary>
        public bool? AllowVAT { get; set; }
        /// <summary>Indicates if the journal automatically saves the entries when the amount is in balance with the entry lines</summary>
        public bool? AutoSave { get; set; }
        /// <summary>Reference to bank account</summary>
        public Guid? Bank { get; set; }
        /// <summary>BIC code of the bank where the bank account is held</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountBICCode { get; set; }
        /// <summary>Country of bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountCountry { get; set; }
        /// <summary>Description of BankAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountDescription { get; set; }
        /// <summary>IBAN of the bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountIBAN { get; set; }
        /// <summary>Reference to the Bank Account linked to the Journal</summary>
        public Guid? BankAccountID { get; set; }
        /// <summary>Bank account number. Is mandatory for Journals that have Type = Bank</summary>
        public string BankAccountIncludingMask { get; set; }
        /// <summary>Obsolete. Whether or not use SEPA for the bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSEPA { get; set; }
        /// <summary>Obsolete. Whether or not use SEPA direct debit for the bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSepaDirectDebit { get; set; }
        /// <summary>Name of bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }
        /// <summary>Primary key</summary>
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
        /// <summary>Default Currency of the Journal. If AllowVariableCurrency is false this is the only currency that can be used</summary>
        public string Currency { get; set; }
        /// <summary>Description of Currency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }
        /// <summary>Name of the Journal</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Suspense general ledger account</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        /// <summary>Description of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        /// <summary>Type of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? GLAccountType { get; set; }
        /// <summary>Primary Key</summary>
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
        /// <summary>General ledger account for payment in transit</summary>
        public Guid? PaymentInTransitAccount { get; set; }
        /// <summary>Identifier detail of the Payment service account. Ex. EmailID for Paypal type of Payment service account</summary>
        public string PaymentServiceAccountIdentifier { get; set; }
        /// <summary>Type of Payment service provider. The following values are supported: 1 (Adyen), 2 (Paypal), 3 (Stripe). Is mandatory for Journals of Type 16 (Payment service)</summary>
        public Int32? PaymentServiceProvider { get; set; }
        /// <summary>Name of the Payment service provider</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentServiceProviderName { get; set; }
        /// <summary>Type of Journal. The following values are supported: 10 (Cash) 12 (Bank) 16 (Payment service) 20 (Sales) 21 (Return invoice) 22 (Purchase) 23 (Received return invoice) 90 (General journal)</summary>
        public Int32? Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Year,Period,Journal")]
    public class JournalStatusList
    {
        /// <summary>Reference to Journal</summary>
        public string Journal { get; set; }
        /// <summary>Description of Journal</summary>
        public string JournalDescription { get; set; }
        /// <summary>Type of Journal 10=Cash, 12=Bank, 20=Sales, 21=Return invoice, 22=Purchase, 23=Received return invoice, 90=General journal</summary>
        public Int32 JournalType { get; set; }
        /// <summary>Description of JournalType</summary>
        public string JournalTypeDescription { get; set; }
        /// <summary>Financial period</summary>
        public Int32 Period { get; set; }
        /// <summary>Journal status for this year and period 0=open, 1=closed</summary>
        public Int32 Status { get; set; }
        /// <summary>Description of Status</summary>
        public string StatusDescription { get; set; }
        /// <summary>Financial year</summary>
        public Int32 Year { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("CurrencyCode")]
    public class OutstandingInvoicesOverview
    {
        /// <summary>Primary key</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Total invoice amount to be paid</summary>
        public double OutstandingPayableInvoiceAmount { get; set; }
        /// <summary>Number of invoices to be paid</summary>
        public double OutstandingPayableInvoiceCount { get; set; }
        /// <summary>Total invoice amount to be received</summary>
        public double OutstandingReceivableInvoiceAmount { get; set; }
        /// <summary>Number of invoices to be received</summary>
        public double OutstandingReceivableInvoiceCount { get; set; }
        /// <summary>Total payable invoice amount that is overdue</summary>
        public double OverduePayableInvoiceAmount { get; set; }
        /// <summary>Number of payable invoices that are overdue</summary>
        public double OverduePayableInvoiceCount { get; set; }
        /// <summary>Total receivable invoice amount that is overdue</summary>
        public double OverdueReceivableInvoiceAmount { get; set; }
        /// <summary>Number of receivable invoices that are overdue</summary>
        public double OverdueReceivableInvoiceCount { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("HID")]
    public class PayablesList
    {
        /// <summary>Code of Account</summary>
        public string AccountCode { get; set; }
        /// <summary>Reference to the account</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public string AccountName { get; set; }
        /// <summary>Amount</summary>
        public double Amount { get; set; }
        /// <summary>Amount in transit</summary>
        public double AmountInTransit { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Date the invoice should be paid</summary>
        public DateTime DueDate { get; set; }
        /// <summary>Entry number</summary>
        public Int32 EntryNumber { get; set; }
        /// <summary>Primary key, human readable ID</summary>
        public Int64 HID { get; set; }
        /// <summary>Obsolete</summary>
        public Guid Id { get; set; }
        /// <summary>Invoice date</summary>
        public DateTime InvoiceDate { get; set; }
        /// <summary>Invoice number. The value is 0 when the invoice number of the linked transaction is empty.</summary>
        public Int32 InvoiceNumber { get; set; }
        /// <summary>Code of Journal</summary>
        public string JournalCode { get; set; }
        /// <summary>Description of Journal</summary>
        public string JournalDescription { get; set; }
        /// <summary>Your reference</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("CurrentYear")]
    public class ProfitLossOverview
    {
        /// <summary>Costs in current period</summary>
        public double CostsCurrentPeriod { get; set; }
        /// <summary>Costs in current year</summary>
        public double CostsCurrentYear { get; set; }
        /// <summary>Costs in previous year</summary>
        public double CostsPreviousYear { get; set; }
        /// <summary>Costs in period of previous year</summary>
        public double CostsPreviousYearPeriod { get; set; }
        /// <summary>Currency code</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Current period</summary>
        public Int32 CurrentPeriod { get; set; }
        /// <summary>Primary key, Current year</summary>
        public Int32 CurrentYear { get; set; }
        /// <summary>Previous year</summary>
        public Int32 PreviousYear { get; set; }
        /// <summary>Period in previous year</summary>
        public Int32 PreviousYearPeriod { get; set; }
        /// <summary>Results of current period</summary>
        public double ResultCurrentPeriod { get; set; }
        public double ResultCurrentYear { get; set; }
        public double ResultPreviousYear { get; set; }
        /// <summary>Results of period in previous year</summary>
        public double ResultPreviousYearPeriod { get; set; }
        /// <summary>Revenue in current period</summary>
        public double RevenueCurrentPeriod { get; set; }
        /// <summary>Revenue in current year</summary>
        public double RevenueCurrentYear { get; set; }
        /// <summary>Revenue in previous year</summary>
        public double RevenuePreviousYear { get; set; }
        /// <summary>Revenue in period of previous year</summary>
        public double RevenuePreviousYearPeriod { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("HID")]
    public class ReceivablesList
    {
        /// <summary>Code of Account</summary>
        public string AccountCode { get; set; }
        /// <summary>Reference to the account</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public string AccountName { get; set; }
        /// <summary>Amount</summary>
        public double Amount { get; set; }
        /// <summary>Amount in transit</summary>
        public double AmountInTransit { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Date the invoice should be paid</summary>
        public DateTime DueDate { get; set; }
        /// <summary>Entry number</summary>
        public Int32 EntryNumber { get; set; }
        /// <summary>Primary key, human readable ID</summary>
        public Int64 HID { get; set; }
        /// <summary>Obsolete</summary>
        public Guid Id { get; set; }
        /// <summary>Invoice date</summary>
        public DateTime InvoiceDate { get; set; }
        /// <summary>Invoice number. The value is 0 when the invoice number of the linked transaction is empty.</summary>
        public Int32 InvoiceNumber { get; set; }
        /// <summary>Code of Journal</summary>
        public string JournalCode { get; set; }
        /// <summary>Description of Journal</summary>
        public string JournalDescription { get; set; }
        /// <summary>Your reference</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReportingBalance
    {
        /// <summary>The sum of the amounts of all transactions in the grouping.</summary>
        public double? Amount { get; set; }
        /// <summary>The sum of the amounts of all credit transactions in the grouping.</summary>
        public double? AmountCredit { get; set; }
        /// <summary>The sum of the amounts of all debit transactions in the grouping.</summary>
        public double? AmountDebit { get; set; }
        /// <summary>Balance type of the G/L account: B = Balance Sheet, W = Profit &amp; Loss.</summary>
        public string BalanceType { get; set; }
        /// <summary>The code of the cost center.</summary>
        public string CostCenterCode { get; set; }
        /// <summary>The description of the cost center.</summary>
        public string CostCenterDescription { get; set; }
        /// <summary>The code of the cost unit.</summary>
        public string CostUnitCode { get; set; }
        /// <summary>The description of the cost unit.</summary>
        public string CostUnitDescription { get; set; }
        /// <summary>The number of transactions in the grouping.</summary>
        public Int32? Count { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>G/L account</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>The code of the G/L account.</summary>
        public string GLAccountCode { get; set; }
        /// <summary>The description of the G/L account.</summary>
        public string GLAccountDescription { get; set; }
        /// <summary>Record ID</summary>
        public Int64 ID { get; set; }
        /// <summary>The reporting period of the transactions in the grouping.</summary>
        public Int32? ReportingPeriod { get; set; }
        /// <summary>The reporting year of the transactions in the grouping.</summary>
        public Int32? ReportingYear { get; set; }
        /// <summary>Status: 20 = Open, 50 = Processed. To get &apos;after entry&apos; results, both Open and Processed amounts have to be included. This is by default, so it requires no extra filtering.</summary>
        public Int32? Status { get; set; }
        /// <summary>The type of the transactions in the grouping.</summary>
        public Int32? Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("DocumentID")]
    public class Return
    {
        /// <summary>Amount in the currency of the transaction</summary>
        public double? Amount { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>Currency</summary>
        public string Currency { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Primary key, document ID</summary>
        public Guid DocumentID { get; set; }
        /// <summary>Url to view the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }
        /// <summary>Due date</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>Frequency</summary>
        public string Frequency { get; set; }
        /// <summary>Payroll declaration type</summary>
        public string PayrollDeclarationType { get; set; }
        /// <summary>Period</summary>
        public Int32 Period { get; set; }
        /// <summary>Description of Period</summary>
        public string PeriodDescription { get; set; }
        /// <summary>Reference to request</summary>
        public Guid? Request { get; set; }
        /// <summary>Status</summary>
        public Int32 Status { get; set; }
        /// <summary>Type</summary>
        public Int32 Type { get; set; }
        /// <summary>Year</summary>
        public Int32 Year { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Year,Period")]
    public class RevenueList
    {
        /// <summary>Total amount in the default currency of the company</summary>
        public double Amount { get; set; }
        /// <summary>Reporting period</summary>
        public Int32 Period { get; set; }
        /// <summary>Current Reporting year</summary>
        public Int32 Year { get; set; }
    }
}
