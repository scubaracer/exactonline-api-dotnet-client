using System.Collections.Generic;
using System;

namespace SalesInvoice
{
    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class InvoiceSalesOrder
    {
        /// <summary>Invoice creation mode- 0: Per customer 1: Per sales order</summary>
        public Int32? CreateMode { get; set; }
        /// <summary>Stock entries entry number.</summary>
        public Int32? DeliveryNumber { get; set; }
        /// <summary>Stock entries entry end date.</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Errors in the process.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Errors { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Invoice quantity processing mode- 0:By quantity delivered 1:By quantity ordered.</summary>
        public Int32? InvoiceMode { get; set; }
        /// <summary>Code of Journal</summary>
        public string JournalCode { get; set; }
        /// <summary>Number of invoices successfully created.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? NumberOfCreatedInvoices { get; set; }
        /// <summary>Number of invoices failed to create.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? NumberOfFailedInvoices { get; set; }
        /// <summary>Collection of Sales order IDs.</summary>
        public IEnumerable<SalesOrderID> SalesOrderIDs { get; set; }
        /// <summary>Stock entries entry start date.</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Possibility to override the InvoiceDate during creation of sales invoice from sales orders. Works only for integration with Intuit QuickBooks.</summary>
        public DateTime? UserInvoiceDate { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Layout
    {
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
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Layout name</summary>
        public string Subject { get; set; }
        /// <summary>Type: 1=Layout, 2=E-mail text layout, 3=Word template</summary>
        public Int16? Type { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("InvoiceID")]
    public class PrintedSalesInvoice
    {
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Contains the id of the document that was created</summary>
        public Guid? Document { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the document</summary>
        public string DocumentCreationError { get; set; }
        /// <summary>Contains information if a document was succesfully created</summary>
        public string DocumentCreationSuccess { get; set; }
        /// <summary>Based on this layout a PDF is created and attached to an Exact Online document and an email</summary>
        public Guid? DocumentLayout { get; set; }
        /// <summary>Contains the error message if an error occurred during the creation of the email</summary>
        public string EmailCreationError { get; set; }
        /// <summary>Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.</summary>
        public string EmailCreationSuccess { get; set; }
        /// <summary>Based on this layout the email text is produced</summary>
        public Guid? EmailLayout { get; set; }
        /// <summary>Extra text that can be added to the printed document and email</summary>
        public string ExtraText { get; set; }
        /// <summary>Date of the invoice</summary>
        public DateTime? InvoiceDate { get; set; }
        /// <summary>Primary key, Reference to EntryID of SalesInvoice</summary>
        public Guid InvoiceID { get; set; }
        /// <summary>Contains the error message if an error occurred during the sending of a postbox message</summary>
        public string PostboxMessageCreationError { get; set; }
        /// <summary>Contains information if a postbox message was succesfully sent</summary>
        public string PostboxMessageCreationSuccess { get; set; }
        /// <summary>The postbox from where the message is sent</summary>
        public Guid? PostboxSender { get; set; }
        /// <summary>Reporting period</summary>
        public Int32? ReportingPeriod { get; set; }
        /// <summary>Reporting year</summary>
        public Int32? ReportingYear { get; set; }
        /// <summary>Set to True if an email containing the invoice should be sent to the invoice customer. This option overrules SendInvoiceToCustomerPostbox.</summary>
        public bool? SendEmailToCustomer { get; set; }
        /// <summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
        public string SenderEmailAddress { get; set; }
        /// <summary>Set to True if a postbox message containing the invoice should be sent to the invoice customer</summary>
        public bool? SendInvoiceToCustomerPostbox { get; set; }
        /// <summary>Set to True if the output preference should be taken from the account. It will be either Document only, Email or Digital postbox. This option overrules both SendEmailToCustomer and SendInvoiceToCustomerPostbox.</summary>
        public bool? SendOutputBasedOnAccount { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("InvoiceID")]
    public class SalesInvoice
    {
        /// <summary>For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        /// <summary>Discount amount in the default currency of the company</summary>
        public double? AmountDiscount { get; set; }
        /// <summary>Discount amount exclude VAT in the default currency of the company</summary>
        public double? AmountDiscountExclVat { get; set; }
        /// <summary>For the header this is the sum of all lines, including VAT</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        /// <summary>For the header this is the sum of all lines, excluding VAT</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFCExclVat { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency for the invoice. Default this is the currency of the administration</summary>
        public string Currency { get; set; }
        /// <summary>Delivery account for invoice</summary>
        public Guid? DeliverTo { get; set; }
        /// <summary>Address of delivery as per invoice delivery account</summary>
        public Guid? DeliverToAddress { get; set; }
        /// <summary>Delivery account person for invoice</summary>
        public Guid? DeliverToContactPerson { get; set; }
        /// <summary>Name of delivery account&apos;s contact person as per invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToContactPersonFullName { get; set; }
        /// <summary>Name of the delivery account&apos;s customer as per invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToName { get; set; }
        /// <summary>Description. Can be different for header and lines</summary>
        public string Description { get; set; }
        /// <summary>Discount percentage</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
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
        /// <summary>Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.</summary>
        public double? ExtraDutyAmountFC { get; set; }
        /// <summary>A positive value of the amount indicates that the amount is to be paid by the customer to your G bank account.In case of a credit invoice the amount should have negative value when retrieved or posted to Exact.</summary>
        public double? GAccountAmountFC { get; set; }
        /// <summary>Official date for the invoice. When the invoice is entered it&apos;s equal to the field &apos;EntryDate&apos;. During the printing process the invoice date can be entered</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? InvoiceDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid InvoiceID { get; set; }
        /// <summary>Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? InvoiceNumber { get; set; }
        /// <summary>Reference to the Customer who will receive the invoice</summary>
        public Guid? InvoiceTo { get; set; }
        /// <summary>Reference to the Contact person of the customer who will receive the invoice</summary>
        public Guid? InvoiceToContactPerson { get; set; }
        /// <summary>Name of the contact person of the customer who will receive the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }
        /// <summary>Name of the customer who will receive the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }
        /// <summary>Indicates whether the invoice has extra duty</summary>
        public bool? IsExtraDuty { get; set; }
        /// <summary>The journal code. Every invoice should be linked to a sales journal</summary>
        public string Journal { get; set; }
        /// <summary>Description of Journal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Order date</summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>Customer who ordered the invoice</summary>
        public Guid? OrderedBy { get; set; }
        /// <summary>Contact person of customer who ordered the invoice</summary>
        public Guid? OrderedByContactPerson { get; set; }
        /// <summary>Name of contact person of customer who ordered the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }
        /// <summary>Name of customer who ordered the invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }
        /// <summary>Number to identify the order. By default the number is based on a setting for the first free number, but you can post your own number.</summary>
        public Int32? OrderNumber { get; set; }
        /// <summary>The payment condition used for due date and discount calculation</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of PaymentCondition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>Payment reference for sales invoice</summary>
        public string PaymentReference { get; set; }
        /// <summary>Extra remarks</summary>
        public string Remarks { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<SalesInvoiceLine> SalesInvoiceLines { get; set; }
        /// <summary>Sales representative</summary>
        public Guid? Salesperson { get; set; }
        /// <summary>Name of sales representative</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }
        /// <summary>Starter Sales invoice status (for starter functionality)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? StarterSalesInvoiceStatus { get; set; }
        /// <summary>Description of StarterSalesInvoiceStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StarterSalesInvoiceStatusDescription { get; set; }
        /// <summary>The status of the entry. 10 = draft. During the creation of an invoice draft records occur in the draft modus if during an invoice a new page with lines is triggered. If the user leaves the invoice in an abnormal way the draft invoices can be recovered. Draft invoices are not included in financial reports, balances etc. 20 = open. Open invoices can be changed. New invoices get the status open by default. 50 = processed. Processed invoices can&apos;t be changed anymore. Processing is done via printing. Processed invoices can&apos;t be reopened</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? TaxSchedule { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        /// <summary>Indicates the type of invoice Values: 8020 - Sales invoices, 8021 - Sales credit note</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of the type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>Total VAT amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }
        /// <summary>Total VAT amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }
        /// <summary>Withholding tax amount applied to sales invoice</summary>
        public double? WithholdingTaxAmountFC { get; set; }
        /// <summary>Withholding tax base amount to calculate withholding amount</summary>
        public double? WithholdingTaxBaseAmount { get; set; }
        /// <summary>Withholding tax percentage applied to sales invoice</summary>
        public double? WithholdingTaxPercentage { get; set; }
        /// <summary>The invoice number of the customer</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesInvoiceLine
    {
        /// <summary>Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        /// <summary>For normal lines it&apos;s the amount excluding VAT</summary>
        public double? AmountFC { get; set; }
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
        /// <summary>Delivery date of an item in a sales invoice. This is used for VAT on prepayments, only if sales order is not used in the license.</summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Description. Can be different for header and lines</summary>
        public string Description { get; set; }
        /// <summary>Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Link to Employee originating from time and cost transactions</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }
        /// <summary>EndTime is used to store the last date of a period. EndTime is used in combination with StartTime</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.</summary>
        public double? ExtraDutyAmountFC { get; set; }
        /// <summary>Extra duty percentage</summary>
        public double? ExtraDutyPercentage { get; set; }
        /// <summary>The GL Account of the sales invoice line. This field is mandatory. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Description of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>The InvoiceID identifies the sales invoice. All the lines of a sales invoice have the same InvoiceID</summary>
        public Guid InvoiceID { get; set; }
        /// <summary>Reference to the item that is sold in this sales invoice line</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Indicates the sequence of the lines within one invoice</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Net price of the sales invoice line</summary>
        public double? NetPrice { get; set; }
        /// <summary>Extra notes</summary>
        public string Notes { get; set; }
        /// <summary>Price list</summary>
        public Guid? Pricelist { get; set; }
        /// <summary>Description of Pricelist</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }
        /// <summary>The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>WBS linked to the sales invoice</summary>
        public Guid? ProjectWBS { get; set; }
        /// <summary>Description of WBS</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectWBSDescription { get; set; }
        /// <summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
        public double? Quantity { get; set; }
        /// <summary>Identifies the sales order this invoice line is based on</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SalesOrder { get; set; }
        /// <summary>Identifies the sales order line this sales invoice line is based on</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SalesOrderLine { get; set; }
        /// <summary>Then line number of the sales order line on which this invoice line is based on</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderLineNumber { get; set; }
        /// <summary>The order number of the sales order on which this invoice line is based on</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>StartTime is used to store the first date of a period. StartTime is used in combination with EndTime</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Subscription { get; set; }
        /// <summary>Description of subscription line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? TaxSchedule { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        /// <summary>Code of Unit</summary>
        public string UnitCode { get; set; }
        /// <summary>Description of Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Price per unit</summary>
        public double? UnitPrice { get; set; }
        /// <summary>VAT amount in the default currency of the company</summary>
        public double? VATAmountDC { get; set; }
        /// <summary>VAT amount in the currency of the transaction</summary>
        public double? VATAmountFC { get; set; }
        /// <summary>The VAT code that is used when the invoice is registered</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        /// <summary>The vat percentage of the VAT code. This is the percentage at the moment the invoice is created. It&apos;s also used for the default calculation of VAT amounts and VAT base amounts</summary>
        public double? VATPercentage { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class SalesOrderID
    {
        public Guid ID { get; set; }
    }
}
