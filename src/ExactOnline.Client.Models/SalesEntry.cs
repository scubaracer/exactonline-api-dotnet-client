using System.Collections.Generic;
using System;

namespace SalesEntry
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class SalesEntry
    {
        /// <summary>Amount in the default currency of the company. For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction. For the header this is the sum of all lines, including VAT</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }
        /// <summary>The number of the batch of entries. Normally a batch consists of multiple entries. Batchnumbers are filled for invoices created by: - Fixed entries - Prolongation (only available with module hosting)</summary>
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
        /// <summary>Currency for the invoice. By default this is the currency of the administration</summary>
        public string Currency { get; set; }
        /// <summary>Reference to customer (account)</summary>
        public Guid? Customer { get; set; }
        /// <summary>Name of customer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CustomerName { get; set; }
        /// <summary>Description. Can be different for header and lines</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document that is manually linked to the invoice</summary>
        public Guid? Document { get; set; }
        /// <summary>Number of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DocumentNumber { get; set; }
        /// <summary>Subject of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>The date when the invoice is entered</summary>
        public DateTime? EntryDate { get; set; }
        /// <summary>The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved</summary>
        public Guid EntryID { get; set; }
        /// <summary>Entry number</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>Description of ExternalLink</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalLinkDescription { get; set; }
        /// <summary>Reference of ExternalLink</summary>
        public string ExternalLinkReference { get; set; }
        /// <summary>A positive value of the amount indicates that the amount is to be paid by the customer to your G bank account.In case of a credit invoice the amount should have negative value when retrieved or posted to Exact.</summary>
        public double? GAccountAmountFC { get; set; }
        /// <summary>Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry</summary>
        public Int32? InvoiceNumber { get; set; }
        /// <summary>Indicates whether the invoice has extra duty</summary>
        public bool? IsExtraDuty { get; set; }
        /// <summary>The journal code. Every invoice should be linked to a sales journal</summary>
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
        /// <summary>Number to indentify the invoice. Order numbers are not unique. Default the number is based on a setting for the first free number</summary>
        public Int32? OrderNumber { get; set; }
        /// <summary>The payment condition used for due date and discount calculation</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of PaymentCondition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>The payment reference used for bank imports, VAT return and Tax reference</summary>
        public string PaymentReference { get; set; }
        public Int32? ProcessNumber { get; set; }
        /// <summary>Foreign currency rate</summary>
        public double? Rate { get; set; }
        /// <summary>The period of the transaction lines. The period should exist in the period date table</summary>
        public Int16? ReportingPeriod { get; set; }
        /// <summary>The financial year to which the entry belongs. The financial year should exist in the period date table</summary>
        public Int16? ReportingYear { get; set; }
        /// <summary>Indicates if amounts are reversed</summary>
        public bool Reversal { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<SalesEntryLine> SalesEntryLines { get; set; }
        /// <summary>Status: 5 = Rejected, 20 = Open, 50 = Processed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Type: 20 = Sales entry, 21 = Sales credit note</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>Vat amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        /// <summary>Vat amount in the currency of the transaction</summary>
        public double? VATAmountFC { get; set; }
        /// <summary>The invoice number of the customer</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesEntryLine
    {
        /// <summary>Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>For normal lines it&apos;s the amount excluding VAT</summary>
        public double AmountFC { get; set; }
        /// <summary>Reference to Asset</summary>
        public Guid? Asset { get; set; }
        /// <summary>Description of Asset</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }
        /// <summary>Reference to Cost center</summary>
        public string CostCenter { get; set; }
        /// <summary>Description of CostCenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        /// <summary>Reference to Cost unit</summary>
        public string CostUnit { get; set; }
        /// <summary>Description of CostUnit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        /// <summary>Description. Can be different for header and lines</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved</summary>
        public Guid EntryID { get; set; }
        /// <summary>Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.</summary>
        public double? ExtraDutyAmountFC { get; set; }
        /// <summary>Extra duty percentage for the item</summary>
        public double? ExtraDutyPercentage { get; set; }
        /// <summary>From date for deferred revenue</summary>
        public DateTime? From { get; set; }
        /// <summary>The GL Account of the invoice line. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory</summary>
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
        /// <summary>Indicates the sequence of the lines within one entry</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Extra notes</summary>
        public string Notes { get; set; }
        /// <summary>The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
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
        /// <summary>When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines</summary>
        public Guid? Subscription { get; set; }
        /// <summary>Description of Subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? TaxSchedule { get; set; }
        /// <summary>To date for deferred revenue</summary>
        public DateTime? To { get; set; }
        /// <summary>Reference to TrackingNumber</summary>
        public Guid? TrackingNumber { get; set; }
        /// <summary>Description of TrackingNumber</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TrackingNumberDescription { get; set; }
        /// <summary>Type: 20 = Sales entry, 21 = Sales credit note</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Type { get; set; }
        /// <summary>VAT amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        /// <summary>VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated. However if the transaction uses extra duty, extra duty amount also needs to be specified. </summary>
        public double? VATAmountFC { get; set; }
        /// <summary>The VAT base amount in the default currency of the company. This is calculated based on the VATBaseAmountFC</summary>
        public double? VATBaseAmountDC { get; set; }
        /// <summary>The VAT base amount in invoice currency. This is calculated with the use of VAT codes. It&apos;s an internal value</summary>
        public double? VATBaseAmountFC { get; set; }
        /// <summary>The VAT code used when the invoice was registered</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        /// <summary>The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It&apos;s also used by the default calculation of VAT amounts and VAT base amounts</summary>
        public double? VATPercentage { get; set; }
    }
}
