using System.Collections.Generic;
using System;

namespace SalesOrder
{
    [SupportedActionsSDK(true, true, true, false)]
    [DataServiceKey("EntryID")]
    public class GoodsDelivery
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
        /// <summary>Reference to account for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryAccount { get; set; }
        /// <summary>Delivery account code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }
        /// <summary>Account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }
        /// <summary>Reference to shipping address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryAddress { get; set; }
        /// <summary>Reference to contact for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryContact { get; set; }
        /// <summary>Name of the contact person of the customer who will receive delivered goods</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryContactPersonFullName { get; set; }
        /// <summary>Date of goods delivery</summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Delivery number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DeliveryNumber { get; set; }
        /// <summary>Header description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Document that is manually linked to the sales order delivery</summary>
        public Guid? Document { get; set; }
        /// <summary>Document Subject</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Primary key</summary>
        public Guid EntryID { get; set; }
        /// <summary>Entry number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<GoodsDeliveryLine> GoodsDeliveryLines { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Remarks</summary>
        public string Remarks { get; set; }
        /// <summary>Reference to shipping method</summary>
        public Guid? ShippingMethod { get; set; }
        /// <summary>Code of shipping method</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodCode { get; set; }
        /// <summary>Description of shipping method</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }
        /// <summary>Reference to header tracking number</summary>
        public string TrackingNumber { get; set; }
        /// <summary>Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, false)]
    [DataServiceKey("ID")]
    public class GoodsDeliveryLine
    {
        /// <summary>Collection of batch numbers</summary>
        public IEnumerable<Inventory.StockBatchNumber> BatchNumbers { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Date of goods delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Description of sales order delivery</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>The EntryID identifies the goods delivery. All the lines of a goods delivery have the same EntryID</summary>
        public Guid? EntryID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>Quantity delivered</summary>
        public double? QuantityDelivered { get; set; }
        /// <summary>Quantity ordered</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityOrdered { get; set; }
        /// <summary>Reference to sales order</summary>
        public Guid? SalesOrderLineID { get; set; }
        /// <summary>Sales order line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderLineNumber { get; set; }
        /// <summary>Sales order number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Collection of serial numbers</summary>
        public IEnumerable<Inventory.StockSerialNumber> SerialNumbers { get; set; }
        /// <summary>Reference to storage location</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Storage location code</summary>
        public string StorageLocationCode { get; set; }
        /// <summary>Storage location description</summary>
        public string StorageLocationDescription { get; set; }
        /// <summary>Reference to tracking number</summary>
        public string TrackingNumber { get; set; }
        /// <summary>Code of item unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unitcode { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("OrderId")]
    public class PrintedSalesOrder
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
        /// <summary>Primary key, Reference to OrderID of SalesOrder</summary>
        public Guid OrderId { get; set; }
        /// <summary>Set to True if an email containing the sales order should be sent to the customer</summary>
        public bool? SendEmailToCustomer { get; set; }
        /// <summary>Email address from which the email will be sent. If not specified, the company email address will be used.</summary>
        public string SenderEmailAddress { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("OrderID")]
    public class SalesOrder
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Discount amount in the default currency of the company</summary>
        public double? AmountDiscount { get; set; }
        /// <summary>Discount amount exclude VAT in the default currency of the company</summary>
        public double? AmountDiscountExclVat { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }
        /// <summary>Amount exclude VAT in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFCExclVat { get; set; }
        /// <summary>Shows if this sales order is approved</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 ApprovalStatus { get; set; }
        /// <summary>Description of ApprovalStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ApprovalStatusDescription { get; set; }
        /// <summary>Approval datetime</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Approved { get; set; }
        /// <summary>User who approved the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Approver { get; set; }
        /// <summary>Name of approver</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ApproverFullName { get; set; }
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
        /// <summary>Reference to delivery customer</summary>
        public Guid? DeliverTo { get; set; }
        /// <summary>Reference to contact person of delivery customer</summary>
        public Guid? DeliverToContactPerson { get; set; }
        /// <summary>Name of contact person of delivery customer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToContactPersonFullName { get; set; }
        /// <summary>Name of delivery customer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliverToName { get; set; }
        /// <summary>Delivery address</summary>
        public Guid? DeliveryAddress { get; set; }
        /// <summary>Delivery date</summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Shipping status</summary>
        public Int16? DeliveryStatus { get; set; }
        /// <summary>Description of DeliveryStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryStatusDescription { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Discount percentage</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document that is manually linked to the sales order</summary>
        public Guid? Document { get; set; }
        /// <summary>Number of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DocumentNumber { get; set; }
        /// <summary>Subject of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Invoice status</summary>
        public Int16? InvoiceStatus { get; set; }
        /// <summary>Description of InvoiceStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvoiceStatusDescription { get; set; }
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
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Order date</summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>Customer who ordered the sales order</summary>
        public Guid? OrderedBy { get; set; }
        /// <summary>Contact person of the customer who ordered the sales order</summary>
        public Guid? OrderedByContactPerson { get; set; }
        /// <summary>Name of contact person of the customer who ordered the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }
        /// <summary>Name of the customer who ordered the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }
        /// <summary>Primary key</summary>
        public Guid OrderID { get; set; }
        /// <summary>Number of sales order</summary>
        public Int32 OrderNumber { get; set; }
        /// <summary>The payment condition used for due date and discount calculation</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of PaymentCondition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>Payment reference for sales order</summary>
        public string PaymentReference { get; set; }
        /// <summary>Extra remarks</summary>
        public string Remarks { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<SalesOrderLine> SalesOrderLines { get; set; }
        /// <summary>Sales representative</summary>
        public Guid? Salesperson { get; set; }
        /// <summary>Name of sales representative</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }
        /// <summary>ShippingMethod</summary>
        public Guid? ShippingMethod { get; set; }
        /// <summary>Description of ShippingMethod</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }
        /// <summary>The status of the sales order. 12 = Open, 20 = Partial, 21 = Complete, 45 = Cancelled.</summary>
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
        /// <summary>Code of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
        /// <summary>Warehouse</summary>
        public Guid? WarehouseID { get; set; }
        /// <summary>The reference number of the customer</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesOrderLine
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double AmountFC { get; set; }
        /// <summary>Reference to Cost center</summary>
        public string CostCenter { get; set; }
        /// <summary>Description of CostCenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        /// <summary>Item cost price</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostPriceFC { get; set; }
        /// <summary>Reference to Cost unit</summary>
        public string CostUnit { get; set; }
        /// <summary>Description of CostUnit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        /// <summary>Delivery date of this line</summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to the item that is sold in this sales order line</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Item Version</summary>
        public Guid? ItemVersion { get; set; }
        /// <summary>Description of Item Version</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        /// <summary>Sales margin of the sales order line</summary>
        public double? Margin { get; set; }
        /// <summary>Net price of the sales order line</summary>
        public double? NetPrice { get; set; }
        /// <summary>Extra notes</summary>
        public string Notes { get; set; }
        /// <summary>The OrderID identifies the sales order. All the lines of a sales order have the same OrderID</summary>
        public Guid OrderID { get; set; }
        /// <summary>Number of sales order</summary>
        public Int32 OrderNumber { get; set; }
        /// <summary>Price list</summary>
        public Guid? Pricelist { get; set; }
        /// <summary>Description of Pricelist</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }
        /// <summary>The project to which the sales order line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Purchase order that is linked to the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? PurchaseOrder { get; set; }
        /// <summary>Purchase order line of the purchase order that is linked to the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? PurchaseOrderLine { get; set; }
        /// <summary>Number of the purchase order line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PurchaseOrderLineNumber { get; set; }
        /// <summary>Number of the purchase order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PurchaseOrderNumber { get; set; }
        /// <summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
        public double? Quantity { get; set; }
        /// <summary>The number of items delivered</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityDelivered { get; set; }
        /// <summary>The number of items invoiced</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityInvoiced { get; set; }
        /// <summary>Reference to ShopOrder</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? TaxSchedule { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }
        /// <summary>Code of item unit</summary>
        public string UnitCode { get; set; }
        /// <summary>Description of Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Price per unit in the currency of the transaction</summary>
        public double? UnitPrice { get; set; }
        /// <summary>Indicates if drop shipment is used (delivery directly to customer, invoice to wholesaler)</summary>
        public byte UseDropShipment { get; set; }
        /// <summary>VAT amount in the currency of the transaction</summary>
        public double? VATAmount { get; set; }
        /// <summary>VAT code</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        /// <summary>The vat percentage of the VAT code. This is the percentage at the moment the sales order is created. It&apos;s also used for the default calculation of VAT amounts and VAT base amounts</summary>
        public double? VATPercentage { get; set; }
    }
}
