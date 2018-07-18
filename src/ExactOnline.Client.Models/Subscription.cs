using System.Collections.Generic;
using System;

namespace Subscription
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class Subscription
    {
        /// <summary>Indicates if subscription is blocked for time cost entry</summary>
        public bool? BlockEntry { get; set; }
        /// <summary>Date of cancellation</summary>
        public DateTime? CancellationDate { get; set; }
        /// <summary>Reference to Classification</summary>
        public Guid? Classification { get; set; }
        /// <summary>Code of Classification</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationCode { get; set; }
        /// <summary>Description of Classification</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Purchase order number of customer</summary>
        public string CustomerPONumber { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>End date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid EntryID { get; set; }
        /// <summary>Invoice Day</summary>
        public byte? InvoiceDay { get; set; }
        /// <summary>Invoice date</summary>
        public DateTime? InvoicedTo { get; set; }
        /// <summary>Reference to invoice account</summary>
        public Guid? InvoiceTo { get; set; }
        /// <summary>Reference to contact person of invoice account</summary>
        public Guid? InvoiceToContactPerson { get; set; }
        /// <summary>Name of contact person of invoice account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }
        /// <summary>Name of invoice account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }
        /// <summary>Invoicing start date</summary>
        public DateTime? InvoicingStartDate { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Remarks</summary>
        public string Notes { get; set; }
        /// <summary>Number</summary>
        public Int32 Number { get; set; }
        /// <summary>Reference to order account</summary>
        public Guid? OrderedBy { get; set; }
        /// <summary>Reference of contact person of order account</summary>
        public Guid? OrderedByContactPerson { get; set; }
        /// <summary>Name of contact person of order account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }
        /// <summary>Name of order account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }
        /// <summary>Payment condition</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of PaymentCondition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>Indicates if subscription is printed</summary>
        public bool Printed { get; set; }
        /// <summary>Reference to reason cancelled</summary>
        public Guid? ReasonCancelled { get; set; }
        /// <summary>Code of ReasonCancelled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledCode { get; set; }
        /// <summary>Description of ReasonCancelled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledDescription { get; set; }
        /// <summary>Start date</summary>
        public DateTime StartDate { get; set; }
        /// <summary>Collection of subscription lines</summary>
        public IEnumerable<SubscriptionLine> SubscriptionLines { get; set; }
        /// <summary>Collection of restriction employees</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionEmployee> SubscriptionRestrictionEmployees { get; set; }
        /// <summary>Collection of restriction items</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionItem> SubscriptionRestrictionItems { get; set; }
        /// <summary>Reference to subscription type</summary>
        public Guid SubscriptionType { get; set; }
        /// <summary>Code of SubscriptionType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeCode { get; set; }
        /// <summary>Description of SubscriptionType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SubscriptionLine
    {
        /// <summary>Amount in the default currency of the company</summary>
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double AmountFC { get; set; }
        /// <summary>Cost center</summary>
        public string Costcenter { get; set; }
        /// <summary>Cost unit</summary>
        public string Costunit { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Discount percentage</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Entry ID</summary>
        public Guid EntryID { get; set; }
        /// <summary>From date</summary>
        public DateTime FromDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to Item</summary>
        public Guid Item { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Line number</summary>
        public Int32 LineNumber { get; set; }
        /// <summary>Reference to LineType</summary>
        public Int16? LineType { get; set; }
        /// <summary>Description of LineType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LineTypeDescription { get; set; }
        /// <summary>Net price in the currency of the transaction</summary>
        public double NetPrice { get; set; }
        /// <summary>Remarks</summary>
        public string Notes { get; set; }
        /// <summary>Quantity</summary>
        public double Quantity { get; set; }
        /// <summary>To date</summary>
        public DateTime? ToDate { get; set; }
        /// <summary>Unit code</summary>
        public string UnitCode { get; set; }
        /// <summary>Description of Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Unit price in the currency of the transaction (price * unit factor)</summary>
        public double UnitPrice { get; set; }
        /// <summary>Vat Amount in the currency of the transaction</summary>
        public double? VATAmountFC { get; set; }
        /// <summary>VATCode</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionLineType
    {
        /// <summary>Description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Int16 ID { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionReasonCode
    {
        /// <summary>Indicates if the reason code is active</summary>
        public bool Active { get; set; }
        /// <summary>Subscription reason code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }
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
        public Guid Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Remarks</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class SubscriptionRestrictionEmployee
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
        public Int32 Division { get; set; }
        /// <summary>Employee linked to the restriction</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }
        /// <summary>Readable ID of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EmployeeHID { get; set; }
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
        /// <summary>Reference to subscription</summary>
        public Guid Subscription { get; set; }
        /// <summary>Description of subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        /// <summary>Number of subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class SubscriptionRestrictionItem
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
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item linked to the restriction</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Reference to subscription</summary>
        public Guid Subscription { get; set; }
        /// <summary>Description of subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        /// <summary>Number of subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionType
    {
        /// <summary>Code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
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
        public DateTime? Modified { get; set; }
        /// <summary>User ID of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }
}
