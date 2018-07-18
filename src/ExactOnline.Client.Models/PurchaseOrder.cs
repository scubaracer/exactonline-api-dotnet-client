using System.Collections.Generic;
using System;

namespace PurchaseOrder
{
    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class GoodsReceipt
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the goods receipt</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document that is linked to the goods receipt</summary>
        public Guid? Document { get; set; }
        /// <summary>Document subject</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Entry number of the resulting stock entry</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>Collection of receipt lines</summary>
        public IEnumerable<GoodsReceiptLine> GoodsReceiptLines { get; set; }
        /// <summary>Primary key</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Date of the goods receipt</summary>
        public DateTime? ReceiptDate { get; set; }
        /// <summary>Receipt number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ReceiptNumber { get; set; }
        /// <summary>Receipt note</summary>
        public string Remarks { get; set; }
        /// <summary>Account ID of the supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Supplier { get; set; }
        /// <summary>Supplier code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierCode { get; set; }
        /// <summary>ID of the contact person at the supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SupplierContact { get; set; }
        /// <summary>Name of the contact person at the supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierContactFullName { get; set; }
        /// <summary>Supplier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }
        /// <summary>Warehouse ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Warehouse code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of the warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
        /// <summary>The purchase invoice number provided by the supplier</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class GoodsReceiptLine
    {
        /// <summary>Collection of batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Inventory.StockBatchNumber> BatchNumbers { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Goods receipt line description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>All the lines of a goods receipt have the same GoodsReceiptID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? GoodsReceiptID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>ID of the received item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of the received item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Item description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Unit code of the purchase</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemUnitCode { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        /// <summary>ID of the storage location in the warehouse where the item is received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Location { get; set; }
        /// <summary>Code of the storage location in the warehouse where the item is received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LocationCode { get; set; }
        /// <summary>Description of the storage location in the warehouse where the item is received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LocationDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>Reference to project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Project { get; set; }
        /// <summary>Project code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Project description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Reference to purchase order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid PurchaseOrderID { get; set; }
        /// <summary>ID of the purchase order line that is received</summary>
        public Guid? PurchaseOrderLineID { get; set; }
        /// <summary>Order number of the purchase order that is received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 PurchaseOrderNumber { get; set; }
        /// <summary>Quantity ordered</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityOrdered { get; set; }
        /// <summary>Quantity received</summary>
        public double? QuantityReceived { get; set; }
        /// <summary>Collection of serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Inventory.StockSerialNumber> SerialNumbers { get; set; }
        /// <summary>Supplier item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierItemCode { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("PurchaseOrderID")]
    public class PurchaseOrder
    {
        /// <summary>Total amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        /// <summary>Total amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
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
        public Guid? DeliveryAddress { get; set; }
        /// <summary>Reference to contact for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryContact { get; set; }
        /// <summary>Name of the contact person of the customer who will receive delivered goods</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryContactPersonFullName { get; set; }
        /// <summary>Description of the purchase order</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Document that is manually linked to the purchase order</summary>
        public Guid? Document { get; set; }
        /// <summary>Subject of the document</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Shows if it is a drop shipment purchase order</summary>
        public bool? DropShipment { get; set; }
        /// <summary>Allows you to set the currency for the invoice. You can only do this if you have checked the Variable: Currency and Variable: Exchange rate fields in the sales journal settings. Once a line has been created in the invoice, the currency can no longer be changed.</summary>
        public double? ExchangeRate { get; set; }
        /// <summary>Invoice status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? InvoiceStatus { get; set; }
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
        /// <summary>Human readable id of the purchase order</summary>
        public Int32? OrderNumber { get; set; }
        /// <summary>Purchase order status: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? OrderStatus { get; set; }
        /// <summary>The payment condition code used for due date and discount calculation</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of payment condition</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }
        /// <summary>Purchase agent</summary>
        public Guid? PurchaseAgent { get; set; }
        /// <summary>Name of purchase agent</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseAgentFullName { get; set; }
        /// <summary>Primary key</summary>
        public Guid PurchaseOrderID { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        /// <summary>This field shows the date the goods are expected to be received.</summary>
        public DateTime? ReceiptDate { get; set; }
        /// <summary>Receipt status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ReceiptStatus { get; set; }
        /// <summary>Include any relevant remarks regarding the purchase order.</summary>
        public string Remarks { get; set; }
        /// <summary>Reference to sales order when purchase order generated via back to back sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SalesOrder { get; set; }
        /// <summary>Number of the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>ShippingMethod</summary>
        public Guid? ShippingMethod { get; set; }
        /// <summary>Description of ShippingMethod</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }
        /// <summary>This shows how the purchase order was created: 1-Manual entry, 2-Import, 3-Other, 4-Purchase order, 5-Sales order, 6-Supplier&apos;s items, 7-Subcontract, 8-Purchase order advice, 9-Shop order, 10-MRP calculation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Source { get; set; }
        /// <summary>Reference to supplier account</summary>
        public Guid? Supplier { get; set; }
        /// <summary>Code of supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierCode { get; set; }
        /// <summary>Contact of supplier</summary>
        public Guid? SupplierContact { get; set; }
        /// <summary>Contact person full name of supplier</summary>
        public string SupplierContactPersonFullName { get; set; }
        /// <summary>Name of supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }
        /// <summary>Total VAT amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmount { get; set; }
        /// <summary>Warehouse</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
        /// <summary>Shows the reference number associated with the purchase order. Enter a description and reference to make the purchase order easier to identify.</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class PurchaseOrderLine
    {
        /// <summary>Amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
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
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the purchase order line</summary>
        public string Description { get; set; }
        /// <summary>Discount in percentage for item</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Expense related to the Work Breakdown Structure of the selected project. Only available with a professional service license</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Expense { get; set; }
        /// <summary>Description of expense. Only available with a professional service license</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExpenseDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>The current stock level of items shown in stock unit. The information is displayed only for items with the stock property selected.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? InStock { get; set; }
        /// <summary>Quantity of item that has been invoiced</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? InvoicedQuantity { get; set; }
        /// <summary>Reference to the item for purchase order</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Indicates if fractional quantities of the item can be used, for example quantity = 0.4</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }
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
        /// <summary>The net price is the unit price (VAT code taken into account) with any discount applied</summary>
        public double? NetPrice { get; set; }
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>Reference to project. Only available with a professional service license</summary>
        public Guid? Project { get; set; }
        /// <summary>Project code. Only available with a professional service license</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of the project. Only available with a professional service license</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>The current stock level + the planned quantity to be received - the planned quantity to deliver shown in stock unit.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ProjectedStock { get; set; }
        /// <summary>Identifies the purchase order. All the lines of a purchase order have the same PurchaseOrderID</summary>
        public Guid PurchaseOrderID { get; set; }
        /// <summary>Quantity in item units</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Quantity { get; set; }
        /// <summary>Quantity in purchase units. Use this field when creating a purchase order</summary>
        public double? QuantityInPurchaseUnits { get; set; }
        /// <summary>Indicates whether the purchase order line needs to be rebilled. Only available with a professional service license</summary>
        public bool? Rebill { get; set; }
        /// <summary>Date the goods are expected to be received</summary>
        public DateTime? ReceiptDate { get; set; }
        /// <summary>Quantity of goods received</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ReceivedQuantity { get; set; }
        /// <summary>Sales order that is linked to a back to back sales order in purchase order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SalesOrder { get; set; }
        /// <summary>Sales order line of the sales order that is linked to a back to back sales order in purchase order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SalesOrderLine { get; set; }
        /// <summary>Number of the sales order line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderLineNumber { get; set; }
        /// <summary>Number of the sales order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Code the supplier uses for this item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierItemCode { get; set; }
        /// <summary>Code of item unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Description of unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Item price per purchase unit</summary>
        public double? UnitPrice { get; set; }
        /// <summary>Amount of VAT charges calculated from total amount and vat percentage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmount { get; set; }
        /// <summary>The VAT code used when the invoice was registered</summary>
        public string VATCode { get; set; }
        /// <summary>Description of vat code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }
        /// <summary>The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It&apos;s also used by the default calculation of VAT amounts and VAT base amounts</summary>
        public double? VATPercentage { get; set; }
    }
}
