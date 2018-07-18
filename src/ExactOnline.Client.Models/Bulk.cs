using System;

namespace Bulk
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Document
    {
        /// <summary>ID of the related account of this document</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double? AmountFC { get; set; }
        /// <summary>Body of this document</summary>
        public string Body { get; set; }
        /// <summary>ID of the category of this document</summary>
        public Guid? Category { get; set; }
        /// <summary>Description of Category</summary>
        public string CategoryDescription { get; set; }
        /// <summary>ID of the related contact of this document</summary>
        public Guid? Contact { get; set; }
        /// <summary>Contact full name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ContactFullName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Entry date of the incoming document</summary>
        public DateTime? DocumentDate { get; set; }
        /// <summary>The Id of document folder</summary>
        public Guid? DocumentFolder { get; set; }
        /// <summary>The Code of document folder</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentFolderCode { get; set; }
        /// <summary>The Decsription of document folder</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentFolderDescription { get; set; }
        /// <summary>Url to view the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }
        /// <summary>Reference to the financial transaction</summary>
        public Guid? FinancialTransactionEntryID { get; set; }
        /// <summary>Indicates that the document body is empty</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasEmptyBody { get; set; }
        /// <summary>Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero</summary>
        public Int32? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>The language code of the document</summary>
        public string Language { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>The opportunity linked to the document</summary>
        public Guid? Opportunity { get; set; }
        /// <summary>The project linked to the document</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>&apos;Our reference&apos; of the transaction that belongs to this document</summary>
        public Int32? SalesInvoiceNumber { get; set; }
        /// <summary>Number of the sales order</summary>
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Send method</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SendMethod { get; set; }
        /// <summary>Number of the shop order</summary>
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Subject of this document</summary>
        public string Subject { get; set; }
        /// <summary>ID of the type of this document</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentAttachment
    {
        /// <summary>Contains the attachment</summary>
        public byte[] Attachment { get; set; }
        /// <summary>Reference to the Document</summary>
        public Guid Document { get; set; }
        /// <summary>Filename of the attachment</summary>
        public string FileName { get; set; }
        /// <summary>File size of the attachment</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double FileSize { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Url of the attachment. To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class FinancialTransactionLine
    {
        /// <summary>Reference to account</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of the Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of the Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Amount in the default currency of the company</summary>
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double AmountFC { get; set; }
        /// <summary>Vat base amount in the currency of the transaction</summary>
        public double? AmountVATBaseFC { get; set; }
        /// <summary>Vat amount in the currency of the transaction</summary>
        public double? AmountVATFC { get; set; }
        /// <summary>Reference to asset</summary>
        public Guid? Asset { get; set; }
        /// <summary>Code of Asset</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }
        /// <summary>Description of Asset</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        /// <summary>Reference to cost center</summary>
        public string CostCenter { get; set; }
        /// <summary>Description of CostCenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        /// <summary>Reference to cost unit</summary>
        public string CostUnit { get; set; }
        /// <summary>Description of CostUnit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency</summary>
        public string Currency { get; set; }
        /// <summary>Date</summary>
        public DateTime? Date { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Reference to document</summary>
        public Guid? Document { get; set; }
        /// <summary>Number of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DocumentNumber { get; set; }
        /// <summary>Subject of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Date that payment should be done</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>Reference to header of the entry</summary>
        public Guid? EntryID { get; set; }
        /// <summary>Entry number of the header</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>Exchange rate</summary>
        public double? ExchangeRate { get; set; }
        /// <summary>Extra duty amount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ExtraDutyAmountFC { get; set; }
        /// <summary>Extra duty percentage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ExtraDutyPercentage { get; set; }
        /// <summary>Financial period</summary>
        public Int16? FinancialPeriod { get; set; }
        /// <summary>Financial year</summary>
        public Int16? FinancialYear { get; set; }
        /// <summary>General ledger account</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        /// <summary>Description of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Invoice number</summary>
        public Int32? InvoiceNumber { get; set; }
        /// <summary>Reference to item</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>The journal code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalCode { get; set; }
        /// <summary>The journal description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Line type</summary>
        public Int16 LineType { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Extra remarks</summary>
        public string Notes { get; set; }
        /// <summary>OffsetID</summary>
        public Guid? OffsetID { get; set; }
        /// <summary>Order number</summary>
        public Int32? OrderNumber { get; set; }
        /// <summary>Discount amount when paid in time</summary>
        public double? PaymentDiscountAmount { get; set; }
        /// <summary>Payment reference</summary>
        public string PaymentReference { get; set; }
        /// <summary>Reference to project</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Quantity</summary>
        public double? Quantity { get; set; }
        /// <summary>Serial number of item</summary>
        public string SerialNumber { get; set; }
        /// <summary>20 = Open, 50 = Processed</summary>
        public Int16? Status { get; set; }
        /// <summary>Reference to subscription line</summary>
        public Guid? Subscription { get; set; }
        /// <summary>Description of subscription line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        /// <summary>Tracking number of item</summary>
        public string TrackingNumber { get; set; }
        /// <summary>Tracking number description</summary>
        public string TrackingNumberDescription { get; set; }
        /// <summary>The transaction type.&lt;/br&gt;&lt;table class=&quot;enum&quot;&gt;&lt;tr&gt;&lt;td&gt;10 = Opening balance&lt;/td&gt;&lt;td&gt;142 = Issue to parent&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;20 = Sales entry&lt;/td&gt;&lt;td&gt;145 = Shop order time entry&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;21 = Sales credit note&lt;/td&gt;&lt;td&gt;146 = Shop order time entry reversal&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;30 = Purchase entry&lt;/td&gt;&lt;td&gt;147 = Shop order by-product receipt&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;31 = Purchase credit note&lt;/td&gt;&lt;td&gt;148 = Shop order by-product reversal&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;40 = Cash flow&lt;/td&gt;&lt;td&gt;150 = Requirement issue&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;50 = VAT return&lt;/td&gt;&lt;td&gt;151 = Requirement reversal&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;70 = Asset - Depreciation&lt;/td&gt;&lt;td&gt;152 = Returned from parent&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;71 = Asset - Investment&lt;/td&gt;&lt;td&gt;155 = Subcontract Issue&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;72 = Asset - Revaluation&lt;/td&gt;&lt;td&gt;156 = Subcontract reversal&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;73 = Asset - Transfer&lt;/td&gt;&lt;td&gt;158 = Shop order completed&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;74 = Asset - Split&lt;/td&gt;&lt;td&gt;162 = Finish assembly&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;75 = Asset - Discontinue&lt;/td&gt;&lt;td&gt;170 = Payroll&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;76 = Asset - Sales&lt;/td&gt;&lt;td&gt;180 = Stock revaluation&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;80 = Revaluation&lt;/td&gt;&lt;td&gt;181 = Financial revaluation&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;82 = Exchange rate difference&lt;/td&gt;&lt;td&gt;195 = Stock count&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;83 = Payment difference&lt;/td&gt;&lt;td&gt;290 = Correction entry&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;84 = Deferred revenue&lt;/td&gt;&lt;td&gt;310 = Period closing&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;85 = Tracking number:Revaluation&lt;/td&gt;&lt;td&gt;320 = Year end reflection&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;86 = Deferred cost&lt;/td&gt;&lt;td&gt;321 = Year end costing&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;87 = VAT on prepayment&lt;/td&gt;&lt;td&gt;322 = Year end profits to gross profit&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;90 = Other&lt;/td&gt;&lt;td&gt;323 = Year end costs to gross profit&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;120 = Delivery&lt;/td&gt;&lt;td&gt;324 = Year end tax&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;121 = Sales return&lt;/td&gt;&lt;td&gt;325 = Year end gross profit to net p/l&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;130 = Receipt&lt;/td&gt;&lt;td&gt;326 = Year end net p/l to balance sheet&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;131 = Purchase return&lt;/td&gt;&lt;td&gt;327 = Year end closing balance&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;140 = Shop order stock receipt&lt;/td&gt;&lt;td&gt;328 = Year start opening balance&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;141 = Shop order stock reversal&lt;/td&gt;&lt;td&gt;3000 = Budget&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;</summary>
        public Int32 Type { get; set; }
        /// <summary>Vat code</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        /// <summary>Vat percentage</summary>
        public double? VATPercentage { get; set; }
        /// <summary>Vat type</summary>
        public string VATType { get; set; }
        /// <summary>Your reference (of customer)</summary>
        public string YourRef { get; set; }
    }
}
