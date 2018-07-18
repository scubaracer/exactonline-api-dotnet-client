using System.Collections.Generic;
using System;

namespace PurchaseEntry
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class PurchaseEntry
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }
        /// <summary>Batch number</summary>
        public Int32? BatchNumber { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Reference to document</summary>
        public Guid? Document { get; set; }
        /// <summary>Document number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DocumentNumber { get; set; }
        /// <summary>Document subject</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Date when payment should be done</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>Entry date</summary>
        public DateTime? EntryDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid EntryID { get; set; }
        /// <summary>Entry number</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>Description of ExternalLink</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalLinkDescription { get; set; }
        public string ExternalLinkReference { get; set; }
        /// <summary>A positive value of the amount indicates that the amount is to be paid to the suppliers G bank account.In case of a credit invoice the amount should have negative value when retrieved or posted to Exact.</summary>
        public double? GAccountAmountFC { get; set; }
        /// <summary>Invoice number</summary>
        public Int32? InvoiceNumber { get; set; }
        /// <summary>Journal</summary>
        public string Journal { get; set; }
        /// <summary>Description of Journal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Order number</summary>
        public Int32? OrderNumber { get; set; }
        /// <summary>Payment condition</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of PaymentCondition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>The payment reference used for bank imports, VAT return and Tax reference</summary>
        public string PaymentReference { get; set; }
        public Int32? ProcessNumber { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<PurchaseEntryLine> PurchaseEntryLines { get; set; }
        /// <summary>Currency exchange rate</summary>
        public double? Rate { get; set; }
        /// <summary>Reporting period</summary>
        public Int16? ReportingPeriod { get; set; }
        /// <summary>Reporting year</summary>
        public Int16? ReportingYear { get; set; }
        /// <summary>Indicates that amounts are reversed</summary>
        public bool? Reversal { get; set; }
        /// <summary>Status: 5 = Rejected, 20 = Open, 50 = Processed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Reference to supplier (account)</summary>
        public Guid? Supplier { get; set; }
        /// <summary>Name of supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }
        /// <summary>Type: 30 = Purchase entry, 31 = Purchase credit note</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>Vat Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        /// <summary>Vat Amount in the currency of the transaction</summary>
        public double? VATAmountFC { get; set; }
        /// <summary>Your reference</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class PurchaseEntryLine
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double AmountFC { get; set; }
        /// <summary>Reference to asset</summary>
        public Guid? Asset { get; set; }
        /// <summary>Asset description</summary>
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
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Reference to header of the purchase entry</summary>
        public Guid? EntryID { get; set; }
        /// <summary>From date for deferred revenue</summary>
        public DateTime? From { get; set; }
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
        /// <summary>IntraStat area</summary>
        public string IntraStatArea { get; set; }
        /// <summary>IntraStatCountry</summary>
        public string IntraStatCountry { get; set; }
        /// <summary>IntraStat delivery term</summary>
        public string IntraStatDeliveryTerm { get; set; }
        /// <summary>IntraStat transaction a</summary>
        public string IntraStatTransactionA { get; set; }
        /// <summary>IntraStat transport method</summary>
        public string IntraStatTransportMethod { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Extra remarks</summary>
        public string Notes { get; set; }
        /// <summary>Reference to project</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Quantity</summary>
        public double? Quantity { get; set; }
        /// <summary>Serial number</summary>
        public string SerialNumber { get; set; }
        /// <summary>Statistical NetWeight</summary>
        public double? StatisticalNetWeight { get; set; }
        /// <summary>Statistical Number</summary>
        public string StatisticalNumber { get; set; }
        /// <summary>Statistical Quantity</summary>
        public double? StatisticalQuantity { get; set; }
        /// <summary>Statistical Value</summary>
        public double? StatisticalValue { get; set; }
        /// <summary>Reference to subscription</summary>
        public Guid? Subscription { get; set; }
        /// <summary>Description of Subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        /// <summary>To date for deferred revenue</summary>
        public DateTime? To { get; set; }
        /// <summary>Reference to tracking number</summary>
        public Guid? TrackingNumber { get; set; }
        /// <summary>Description of TrackingNumber</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TrackingNumberDescription { get; set; }
        /// <summary>Type: 30 = Purchase entry, 31 = Purchase credit note</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Type { get; set; }
        /// <summary>VAT amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        /// <summary>VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated.</summary>
        public double? VATAmountFC { get; set; }
        /// <summary>VAT base amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountDC { get; set; }
        /// <summary>VAT base amount in the currency of the transaction</summary>
        public double? VATBaseAmountFC { get; set; }
        /// <summary>VAT code</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        /// <summary>If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices.</summary>
        public double? VATNonDeductiblePercentage { get; set; }
        /// <summary>VAT percentage</summary>
        public double? VATPercentage { get; set; }
        /// <summary>Withholding tax amount for spanish legislation</summary>
        public double? WithholdingAmountDC { get; set; }
        /// <summary>Withholding tax key for spanish legislation</summary>
        public string WithholdingTax { get; set; }
    }
}
