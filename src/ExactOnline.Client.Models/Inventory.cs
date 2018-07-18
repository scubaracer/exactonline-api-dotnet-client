using System.Collections.Generic;
using System;

namespace Inventory
{
    using Newtonsoft.Json;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AssemblyOrder
    {
        /// <summary>Planned date for assembly of the item</summary>
        public DateTime? AssemblyDate { get; set; }
        /// <summary>Description of assembly order</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Quantity of items that have actually been assembled</summary>
        public double FinishedQuantity { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to item</summary>
        public Guid Item { get; set; }
        /// <summary>Item code</summary>
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        public string ItemDescription { get; set; }
        /// <summary>Notes of the assembly order</summary>
        public string Notes { get; set; }
        /// <summary>Date of the assembly order is initiated</summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>Assembly order number </summary>
        public Int32 OrderNumber { get; set; }
        /// <summary>Assembly order status: 20 = Open, 30 = Partial, 50 = Complete</summary>
        public Int32 OrderStatus { get; set; }
        /// <summary>Collection of part items for assembly order</summary>

        /// <summary>Planned quantity of the item to be assembled</summary>
        public double PlannedQuantity { get; set; }
        /// <summary>Reference to storage location</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Storage location code</summary>
        public string StorageLocationCode { get; set; }
        /// <summary>Storage location description</summary>
        public string StorageLocationDescription { get; set; }
        /// <summary>Warehouse</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of Warehouse</summary>
        public string WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class BatchNumber
    {
        /// <summary>Available quantity of this batch number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AvailableQuantity { get; set; }
        /// <summary>Human readable batch number</summary>
        [JsonProperty(PropertyName = "batchNumber")]
        public string BatchNumberString { get; set; }
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
        /// <summary>Expiry date of effective period for batch number</summary>
        public DateTime? ExpiryDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Boolean value indicating whether or not the batch number is blocked</summary>
        public byte? IsBlocked { get; set; }
        /// <summary>Item</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
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
        /// <summary>Total quantity available per location</summary>
        public IEnumerable<Inventory.BatchQuantitiesPerLocation> StorageLocations { get; set; }
        /// <summary>Total quantity available per warehouse</summary>
        public IEnumerable<Inventory.BatchQuantitiesPerWarehouse> Warehouses { get; set; }
    }

    [SupportedActionsSDK(false, false, false, false)]
    [DataServiceKey("BatchNumberId")]
    public class BatchQuantitiesPerLocation
    {
        public double AvailableQuantity { get; set; }
        public Guid BatchNumberId { get; set; }
        public Guid? StorageLocation { get; set; }
        public string StorageLocationCode { get; set; }
        public string StorageLocationDescription { get; set; }
        public Guid? Warehouse { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, false, false, false)]
    [DataServiceKey("BatchNumberId")]
    public class BatchQuantitiesPerWarehouse
    {
        public double AvailableQuantity { get; set; }
        public Guid BatchNumberId { get; set; }
        public Guid? Warehouse { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ItemWarehous
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
        /// <summary>Quantity that is currently on stock, sales/purchase orders excluded</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CurrentStock { get; set; }
        /// <summary>This is a default storage location</summary>
        public Guid? DefaultStorageLocation { get; set; }
        /// <summary>Default storage location&apos;s code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DefaultStorageLocationCode { get; set; }
        /// <summary>Default storage location&apos;s description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DefaultStorageLocationDescription { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item ID</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of this item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemIsFractionAllowedItem { get; set; }
        /// <summary>The standard unit code of this item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemUnit { get; set; }
        /// <summary>Description of item&apos;s unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemUnitDescription { get; set; }
        /// <summary>Maximum number of stock could enter warehouse</summary>
        public double? MaximumStock { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>The quantity still open to be received based on i.e. purchase orders and assembly orders.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? PlannedStockIn { get; set; }
        /// <summary>The quantity still open to be delivered based on i.e. sales orders and assembly orders.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? PlannedStockOut { get; set; }
        /// <summary>URL of the stock planning details of this record</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PlanningDetailsUrl { get; set; }
        /// <summary>The quantity of stock projected given all planned future stock changes</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ProjectedStock { get; set; }
        /// <summary>Reorder point when stock depletes</summary>
        public double? ReorderPoint { get; set; }
        /// <summary>The quantity in a back to back order process which is already received from the purchase order, but not yet delivered for the sales order.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ReservedStock { get; set; }
        /// <summary>Safety stock</summary>
        public double? SafetyStock { get; set; }
        /// <summary>URL pointing to details of which storage locations this ItemWarehouse&apos;s stock is located</summary>
        public string StorageLocationUrl { get; set; }
        /// <summary>Warehouse ID</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Item")]
    public class ItemWarehousePlanningDetail
    {
        /// <summary>ID of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Item { get; set; }
        /// <summary>Code of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Date which quantity in stock is planned to change</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime PlannedDate { get; set; }
        /// <summary>Amount by which quantity in stock is planned to change</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double PlannedQuantity { get; set; }
        /// <summary>Human readable description of the PlanningSource (translated to user&apos;s language) - Examples: Purchase Order, Sales Order, Shop Order, etc.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PlanningSourceDescription { get; set; }
        /// <summary>ID of the PlanningSource</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? PlanningSourceID { get; set; }
        /// <summary>Line number of the PlanningSource if the PlanningSourceType supports line numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PlanningSourceLineNumber { get; set; }
        /// <summary>Human readable number of the PlanningSource - Examples: Shop order number &apos;201600001&apos; or Sales order number &apos;2016020001&apos;</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PlanningSourceNumber { get; set; }
        /// <summary>REST API URL of this specific PlanningSource and PlanningSourceID (Assembly orders and warehouse transfers not supported over REST)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PlanningSourceUrl { get; set; }
        /// <summary>Type of the PlanningSource - 120=GoodsDelivery, 124=WarehouseTransferDelivery, 130=GoodsReceipt, 134=WarehouseTransferReceipt, 140=ShopOrderStockReceipt, 147=ShopOrderByProductReceipt, 150=ShopOrderRequirement, 160=AssemblyOrderReceipt, 165=AssemblyOrderIssue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? PlanningType { get; set; }
        /// <summary>Human readable description of the PlanningSourceType (translated to user&apos;s language) - Examples: &apos;Shop order stock receipt&apos; or &apos;Goods delivery&apos;</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PlanningTypeDescription { get; set; }
        /// <summary>ID of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Warehouse { get; set; }
        /// <summary>Code of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemWarehouseStorageLocation
    {
        /// <summary>Uniquely identifies the item, warehouse, storage location combination</summary>
        public Guid ID { get; set; }
        /// <summary>Does the item allow partial quantities (1.75 meters)</summary>
        public byte IsFractionAllowedItem { get; set; }
        /// <summary>Item</summary>
        public Guid Item { get; set; }
        /// <summary>Code of the item of this stock quantity</summary>
        public string ItemCode { get; set; }
        /// <summary>Description of the item of this stock quantity</summary>
        public string ItemDescription { get; set; }
        /// <summary>Unit of the item</summary>
        public string ItemUnit { get; set; }
        /// <summary>Unit description of the item</summary>
        public string ItemUnitDescription { get; set; }
        /// <summary>Number of items in stock</summary>
        public double? Stock { get; set; }
        /// <summary>Storage location of this stock</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of the storage location of this stock quantity</summary>
        public string StorageLocationCode { get; set; }
        /// <summary>Description of the storage location of this stock quantity</summary>
        public string StorageLocationDescription { get; set; }
        /// <summary>ID of Warehouse</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of the warehouse of this stock quantity</summary>
        public string WarehouseCode { get; set; }
        /// <summary>Description of the warehouse of this stock quantity</summary>
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("StockCountID")]
    public class ProcessStockCount
    {
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the processing of the stock count.</summary>
        public string ErrorMessage { get; set; }
        /// <summary>Primary key</summary>
        public Guid StockCountID { get; set; }
        /// <summary>Contains information if the stock count was successfully processed.</summary>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SerialNumber
    {
        /// <summary>Availability of this serial number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? Available { get; set; }
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
        /// <summary>End date of effective period for serial number</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Boolean value indicating whether or not the serial number is blocked</summary>
        public byte? IsBlocked { get; set; }
        /// <summary>Item</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
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
        /// <summary>Human readable serial number</summary>
        [JsonProperty(PropertyName = "SerialNumber")]
        public string SerialNumberString { get; set; }
        /// <summary>Start date of effective period for serial number</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>ID of storage location where serial number is available</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location where serial number is available</summary>
        public string StorageLocationCode { get; set; }
        /// <summary>Description of storage location where serial number is available</summary>
        public string StorageLocationDescription { get; set; }
        /// <summary>ID of warehouse where serial number is available</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse where serial number is available</summary>
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse where serial number is available</summary>
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class StockBatchNumber
    {
        /// <summary>Human readable batch number</summary>
        public string BatchNumber { get; set; }
        /// <summary>Batch number ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? BatchNumberID { get; set; }
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
        /// <summary>ID representing a group of batch numbers being reserved for use in a subsequent stock transaction</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>End date of effective period for batch number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Boolean value indicating whether or not the batch number is blocked</summary>
        public byte? IsBlocked { get; set; }
        /// <summary>Boolean value indicating if this batch number is being reserved</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsDraft { get; set; }
        /// <summary>Item</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Quantity of this batch number entering or leaving inventory</summary>
        public double? Quantity { get; set; }
        /// <summary>Remarks</summary>
        public string Remarks { get; set; }
        /// <summary>ID of stock count entry</summary>
        public Guid? StockCountLine { get; set; }
        /// <summary>ID of the stock transaction in which this batch number was used</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StockTransactionID { get; set; }
        /// <summary>Type of stock transaction associated with this batch number.&lt;br&gt;&lt;br&gt;Available values:&lt;br&gt;10 = Opening balance&lt;br&gt;120 = Goods delivery&lt;br&gt;121 = Sales return&lt;br&gt;122 = Stock out (Drop shipment)&lt;br&gt;123 = Stock in (Drop shipment return)&lt;br&gt;124 = Warehouse transfer delivery&lt;br&gt;125 = Location Transfer Delivery&lt;br&gt;130 = Goods receipt&lt;br&gt;131 = Purchase return&lt;br&gt;132 = Stock in (Drop shipment)&lt;br&gt;133 = Stock out (Drop shipment return)&lt;br&gt;134 = Warehouse transfer receipt&lt;br&gt;135 = Location Transfer Receipt&lt;br&gt;140 = Shop order stock receipt&lt;br&gt;141 = Shop order stock reversal&lt;br&gt;147 = Shop order by-product receipt&lt;br&gt;148 = Shop order by-product reversal&lt;br&gt;150 = Requirement issue&lt;br&gt;151 = Requirement reversal&lt;br&gt;155 = Subcontract issue&lt;br&gt;156 = Subcontract return&lt;br&gt;160 = Receipt (Assembly)&lt;br&gt;161 = Return receipt (Disassembly)&lt;br&gt;165 = Issue (Assembly)&lt;br&gt;166 = Return issue (Disassembly)&lt;br&gt;180 = Stock revaluation&lt;br&gt;181 = Financial revaluation&lt;br&gt;195 = Stock count&lt;br&gt;196 = Adjust stock - out&lt;br&gt;197 = Adjust stock - in&lt;br&gt;</summary>
        public Int32? StockTransactionType { get; set; }
        /// <summary>Storage location which this batch number is entering or leaving</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of the storage location which this batch number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of the storage location which this batch number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Warehouse which this batch number is entering or leaving</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of the warehouse which this batch number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of the warehouse which this batch number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("StockCountID")]
    public class StockCount
    {
        /// <summary>Stock count user</summary>
        public Guid? CountedBy { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the stock count</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Entry number of the stock transactions</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Offset GL account of inventory</summary>
        public Guid? OffsetGLInventory { get; set; }
        /// <summary>GLAccount code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OffsetGLInventoryCode { get; set; }
        /// <summary>GLAccount description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OffsetGLInventoryDescription { get; set; }
        /// <summary>Source of stock count entry: 1-Manual entry, 2-Import, 3-Stock count, 4-Web service</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Source { get; set; }
        /// <summary>Stock count status: 12-Draft, 21-Processed</summary>
        public Int16? Status { get; set; }
        /// <summary>Stock count date</summary>
        public DateTime? StockCountDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid StockCountID { get; set; }
        /// <summary>Collection of stock count lines</summary>
        public IEnumerable<Inventory.StockCountLine> StockCountLines { get; set; }
        /// <summary>Human readable id of the stock count</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? StockCountNumber { get; set; }
        /// <summary>Warehouse</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class StockCountLine
    {
        /// <summary>The collection of batch numbers that belong to the items included in this stock count</summary>
        public IEnumerable<Inventory.StockBatchNumber> BatchNumbers { get; set; }
        /// <summary>Cost price of the item that is used to create the stock count</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostPrice { get; set; }
        /// <summary>Counted by</summary>
        public Guid? CountedBy { get; set; }
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
        /// <summary>Reference to the item for which the stock is counted</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Current standard/actual item cost price</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ItemCostPrice { get; set; }
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
        /// <summary>The difference between the current quantity in stock and the new quantity in stock. For example specify -1 for this field to correct the quantity if one item in stock is broken.</summary>
        public double? QuantityDifference { get; set; }
        /// <summary>The current quantity available in stock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityInStock { get; set; }
        /// <summary>The new quantity in stock. Use this field to correct the quantity when the items in stock are physically counted.</summary>
        public double? QuantityNew { get; set; }
        /// <summary>The collection of serial numbers that belong to the items included in this stock count</summary>
        public IEnumerable<Inventory.StockSerialNumber> SerialNumbers { get; set; }
        /// <summary>Identifies the stock count. All the lines of a stock count have the same StockCountID</summary>
        public Guid? StockCountID { get; set; }
        /// <summary>Stock item&apos;s unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StockKeepingUnit { get; set; }
        /// <summary>This property is package specific (Stock count can have multiple lines for the same item only if it is for multiple storage locations).</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Storage location code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Storage location description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class StockSerialNumber
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
        /// <summary>ID representing a group of serial numbers being reserved for use in a subsequent stock transaction</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>End date of effective period for serial number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Boolean value indicating whether or not the serial number is blocked</summary>
        public byte? IsBlocked { get; set; }
        /// <summary>Boolean value indicating if this serial number is being reserved</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsDraft { get; set; }
        /// <summary>Item</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
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
        /// <summary>Human readable serial number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SerialNumber { get; set; }
        /// <summary>Serial number ID</summary>
        public Guid? SerialNumberID { get; set; }
        /// <summary>Start date of effective period for serial number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? StartDate { get; set; }
        /// <summary>ID of stock count entry</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StockCountLine { get; set; }
        /// <summary>ID of the stock transaction in which this serial number was used</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StockTransactionID { get; set; }
        /// <summary>Type of stock transaction associated with this serial number.&lt;br&gt;&lt;br&gt;Available values:&lt;br&gt;10 = Opening balance&lt;br&gt;120 = Goods delivery&lt;br&gt;121 = Sales return&lt;br&gt;122 = Stock out (Drop shipment)&lt;br&gt;123 = Stock in (Drop shipment return)&lt;br&gt;124 = Warehouse transfer delivery&lt;br&gt;125 = Location Transfer Delivery&lt;br&gt;130 = Goods receipt&lt;br&gt;131 = Purchase return&lt;br&gt;132 = Stock in (Drop shipment)&lt;br&gt;133 = Stock out (Drop shipment return)&lt;br&gt;134 = Warehouse transfer receipt&lt;br&gt;135 = Location Transfer Receipt&lt;br&gt;140 = Shop order stock receipt&lt;br&gt;141 = Shop order stock reversal&lt;br&gt;147 = Shop order by-product receipt&lt;br&gt;148 = Shop order by-product reversal&lt;br&gt;150 = Requirement issue&lt;br&gt;151 = Requirement reversal&lt;br&gt;155 = Subcontract issue&lt;br&gt;156 = Subcontract return&lt;br&gt;160 = Receipt (Assembly)&lt;br&gt;161 = Return receipt (Disassembly)&lt;br&gt;165 = Issue (Assembly)&lt;br&gt;166 = Return issue (Disassembly)&lt;br&gt;180 = Stock revaluation&lt;br&gt;181 = Financial revaluation&lt;br&gt;195 = Stock count&lt;br&gt;196 = Adjust stock - out&lt;br&gt;197 = Adjust stock - in&lt;br&gt;</summary>
        public Int32? StockTransactionType { get; set; }
        /// <summary>Storage location which this serial number is entering or leaving</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of the storage location which this serial number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of the storage location which this serial number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Warehouse which this serial number is entering or leaving</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Code of the warehouse which this serial number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of the warehouse which this serial number is entering or leaving</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class StorageLocation
    {
        /// <summary>Code of the storage location</summary>
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
        /// <summary>Description of the storage location</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the main storage location. There&apos;s always exactly one main storage location per warehouse</summary>
        public byte? Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Warehouse ID</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Warehouse Code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Warehouse
    {
        /// <summary>Code of the warehouse</summary>
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
        /// <summary>The default storage location of this warehouse. Warehouses can have a default storage location in packages Manufacturing Premium or Wholesale Premium</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DefaultStorageLocation { get; set; }
        /// <summary>Default storage location&apos;s code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DefaultStorageLocationCode { get; set; }
        /// <summary>Default storage location&apos;s description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DefaultStorageLocationDescription { get; set; }
        /// <summary>The description of the warehouse</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Email address</summary>
        public string EMail { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the main warehouse. There&apos;s always exactly one main warehouse per administration</summary>
        public byte Main { get; set; }
        /// <summary>User reponsible for the warehouse</summary>
        public Guid? ManagerUser { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Indicates if this warehouse is using storage locations. The storage locations will not be removed when when this is deactivated</summary>
        public byte UseStorageLocations { get; set; }
    }
}
