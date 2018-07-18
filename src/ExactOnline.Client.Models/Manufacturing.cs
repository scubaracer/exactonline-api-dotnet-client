using System.Collections.Generic;
using System;

namespace Manufacturing
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class BillOfMaterialMaterial
    {
        /// <summary>Item average cost available when average cost method is used</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? AverageCost { get; set; }
        /// <summary>Indicates if this is a backflush item</summary>
        public byte? Backflush { get; set; }
        /// <summary>Calculator type</summary>
        public Int32? CalculatorType { get; set; }
        /// <summary>Cost batch</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostBatch { get; set; }
        /// <summary>Cost center</summary>
        public string CostCenter { get; set; }
        /// <summary>Cost center description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }
        /// <summary>Cost unit</summary>
        public string CostUnit { get; set; }
        /// <summary>Cost unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the material</summary>
        public string Description { get; set; }
        /// <summary>Detail drawing reference</summary>
        public string DetailDrawing { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        /// <summary>Key of item version</summary>
        public Guid? ItemVersion { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Net weight</summary>
        public double? NetWeight { get; set; }
        /// <summary>Net weight unit of measure</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string NetWeightUnit { get; set; }
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>Key of part item</summary>
        public Guid? PartItem { get; set; }
        /// <summary>Part item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartItemCode { get; set; }
        /// <summary>Item standard cost available when standard cost method is used</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? PartItemCostPriceStandard { get; set; }
        /// <summary>Part item description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PartItemDescription { get; set; }
        /// <summary>Quantity</summary>
        public double? Quantity { get; set; }
        /// <summary>Quantity batch</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityBatch { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? syscreated { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? syscreator { get; set; }
        /// <summary>Modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? sysmodified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? sysmodifier { get; set; }
        /// <summary>Material type 1 indicates material, 2 indicates byproduct</summary>
        public Int32? Type { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class BillOfMaterialVersion
    {
        /// <summary>Batch Quantity of Item Version</summary>
        public double? BatchQuantity { get; set; }
        /// <summary>Cad drawing URL</summary>
        public string CadDrawingUrl { get; set; }
        /// <summary>Calculated Cost Price of Item Version</summary>
        public double? CalculatedCostPrice { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the item version</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the default item version that will be assigned when a item is selected</summary>
        public byte IsDefault { get; set; }
        /// <summary>Reference to Items table</summary>
        public Guid Item { get; set; }
        /// <summary>Description of Item</summary>
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
        /// <summary>Line notes</summary>
        public string Notes { get; set; }
        /// <summary>Order lead days for item</summary>
        public Int32? OrderLeadDays { get; set; }
        /// <summary>Production lead time in days of Item version</summary>
        public Int32? ProductionLeadDays { get; set; }
        /// <summary>Statuses of Item version: 10-Engineering change pending, 20-Engineering change approved, 30-Active &amp; 40-Historic</summary>
        public Int16? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Type of Item version: 10-Sales bill of material, 20-Manufacturing recipe</summary>
        public Int16? Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>Version date</summary>
        public DateTime? VersionDate { get; set; }
        /// <summary>Version Number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? VersionNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("StockTransactionId")]
    public class ByProductReceipt
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date this by-product finish was created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Serial or batch numbers are reserved prior to a POST to ByProductReceipts. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>Indicates if this ByProductReceipt has a quantity eligible to be reversed via ByProductReversals</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasReversibleQuantity { get; set; }
        /// <summary>Boolean indicating if this by-product finish was the result of shop order backflushing</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool IsBackflush { get; set; }
        /// <summary>Does the ByProductReceipt&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ByProductReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the ByProductReceipt&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>ID of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Quantity of this by-product finish</summary>
        public double? Quantity { get; set; }
        /// <summary>ID of shop order, which produced the by-product</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>ID of the shop order material plan for this by-product</summary>
        public Guid? ShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order, which produced the by-product</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of stock transaction related to this by-product finish</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid StockTransactionId { get; set; }
        /// <summary>ID of storage location finished to</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of storage location finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Effective date of this by-product finish</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ReversalStockTransactionId")]
    public class ByProductReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date of this reversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Boolean indicating if this reversal was the result of shop order backflushing, processed during a ShopOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool IsBackflush { get; set; }
        /// <summary>Does the ByProductReversal&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ByProductReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the ByProductReversal&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>Item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Notes associated with this reversal</summary>
        public string Note { get; set; }
        /// <summary>ID of the original stock transaction, which was reversed</summary>
        public Guid? OriginalStockTransactionId { get; set; }
        /// <summary>Quantity reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Quantity { get; set; }
        /// <summary>ID of stock transaction related to this ByProductReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ReversalStockTransactionId { get; set; }
        /// <summary>Shop order being reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>ID of shop order material plan</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order being reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Effective date of this ByProductReversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("StockTransactionId")]
    public class MaterialIssue
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date this material issue was created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Serial or batch numbers are reserved prior to a POST to MaterialIssues. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>Indicates if this MaterialIssue has a quantity eligible to be reversed via MaterialReversals</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasReversibleQuantity { get; set; }
        /// <summary>Boolean indicating if this material issue was the result of shop order backflushing</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBackflush { get; set; }
        /// <summary>Does the material issue&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material issue&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Boolean indicating if this material issue was an issue to a parent shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsIssueFromChild { get; set; }
        /// <summary>Does the material issue&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>Item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Notes logged with this material issue</summary>
        public string Note { get; set; }
        /// <summary>Quantity of this material issue</summary>
        public double? Quantity { get; set; }
        /// <summary>If this transaction was part of a SubOrderReceipt, this ID is the related ShopOrderReceipt.StockTransactionID.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RelatedStockTransaction { get; set; }
        /// <summary>ID of shop order issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>ID of shop order material plan</summary>
        public Guid? ShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of stock transaction related to this material issue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid StockTransactionId { get; set; }
        /// <summary>ID of storage location issued from</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of storage location issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Effective date of this material issue</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ReversalStockTransactionId")]
    public class MaterialReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date this reversal was created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Boolean indicating if this reversal was the result of shop order backflushing, processed during a ShopOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool IsBackflush { get; set; }
        /// <summary>Does the issue reversal&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material reversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the issue reversal&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>Item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of item issued</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Notes logged with this reversal</summary>
        public string Note { get; set; }
        /// <summary>ID of the original stock transaction, which was reversed</summary>
        public Guid? OriginalStockTransactionId { get; set; }
        /// <summary>Quantity of this reversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Quantity { get; set; }
        /// <summary>ID of stock transaction related to this material issue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ReversalStockTransactionId { get; set; }
        /// <summary>ID of shop order reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>ID of shop order material plan</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of storage location reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of storage location reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Effective date of this reversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Operation
    {
        /// <summary>Code of the operation</summary>
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
        /// <summary>Description of the operation</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Indicates if the operation has suppliers associated with it</summary>
        public byte? HasSuppliers { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to Items table</summary>
        public Guid? Item { get; set; }
        /// <summary>Description of Item</summary>
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
        /// <summary>Extra remarks</summary>
        public string Notes { get; set; }
        /// <summary>Search code for the operation</summary>
        public string Searchcode { get; set; }
        /// <summary>Status of the operation</summary>
        public Int32? Status { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class OperationResource
    {
        /// <summary>Reference to Accounts</summary>
        public Guid? Account { get; set; }
        /// <summary>Attended percentage</summary>
        public double? AttendedPercentage { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Reference to Currencies</summary>
        public string Currency { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Efficiency percentage</summary>
        public double? EfficiencyPercentage { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the primary operation of the workcenter</summary>
        public byte? IsPrimary { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Reference to Operations</summary>
        public Guid? Operation { get; set; }
        /// <summary>Description of Operation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OperationDescription { get; set; }
        /// <summary>Lead days from purchase</summary>
        public Int32? PurchaseLeadDays { get; set; }
        /// <summary>Unit of purchased item from supplier</summary>
        public string PurchaseUnit { get; set; }
        /// <summary>VAT code used for purchased item from supplier</summary>
        public string PurchaseVATCode { get; set; }
        /// <summary>Used in conjuction with RunMethod and EfficiencyPercentage to determine PlannedRunHours</summary>
        public double? Run { get; set; }
        /// <summary>Reference to OperationRunMethods</summary>
        public Int32? RunMethod { get; set; }
        /// <summary>Used in conjunction with SetupCount and SetupUnit to determine PlannedSetupHours</summary>
        public double? Setup { get; set; }
        /// <summary>Reference to TimeUnits</summary>
        public string SetupUnit { get; set; }
        /// <summary>Reference to RoutingStepTypes</summary>
        public Int32? Type { get; set; }
        /// <summary>Reference to Workcenter</summary>
        public Guid? Workcenter { get; set; }
        /// <summary>Description of Workcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WorkcenterDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProductionArea
    {
        /// <summary>Code of the production area group</summary>
        public string Code { get; set; }
        /// <summary>Reference to Cost center</summary>
        public string Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        /// <summary>Reference to Cost unit</summary>
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
        /// <summary>Description of the production area</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the default production area. This will be used when creating a new production area</summary>
        public byte IsDefault { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Production area notes</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrder
    {
        /// <summary>URL to CAD Drawing Specified on Manufacturing Bill of Material</summary>
        public string CADDrawingURL { get; set; }
        /// <summary>The cost center linked to the shop order</summary>
        public string Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        /// <summary>The cost unit linked to the shop order</summary>
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
        /// <summary>Description of the shop order</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Date on which the shop order was placed</summary>
        public DateTime? EntryDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Does the material plan&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the material plan&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsFractionAllowedItem { get; set; }
        /// <summary>Indicator that Shop order is in planning</summary>
        public byte IsInPlanning { get; set; }
        /// <summary>Indicator if the Shop order is on hold</summary>
        public byte IsOnHold { get; set; }
        /// <summary>Indicator that the Shop order has been released to production</summary>
        public byte IsReleased { get; set; }
        /// <summary>Does the material plan&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsSerial { get; set; }
        /// <summary>Reference to the item</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>URL of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Reference to ItemVersion</summary>
        public Guid? ItemVersion { get; set; }
        /// <summary>Description of Item Version</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Notes - only viewed internally</summary>
        public string Notes { get; set; }
        /// <summary>Planned end date of this shop order</summary>
        public DateTime? PlannedDate { get; set; }
        /// <summary>Planned quantity</summary>
        public double? PlannedQuantity { get; set; }
        /// <summary>Planned start date of this shop order</summary>
        public DateTime? PlannedStartDate { get; set; }
        /// <summary>Produced quantity</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? ProducedQuantity { get; set; }
        /// <summary>Production lead days</summary>
        public Int32 ProductionLeadDays { get; set; }
        /// <summary>Reference to Project</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Quantity ready to ship</summary>
        public double? ReadyToShipQuantity { get; set; }
        /// <summary>Number of sales orders linked to this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderLineCount { get; set; }
        /// <summary>Collection of Sales order lines</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<SalesOrder.SalesOrderLine> SalesOrderLines { get; set; }
        /// <summary>Number of shop order by-product plans, which are backflushed, for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderByProductPlanBackflushCount { get; set; }
        /// <summary>Number of shop order by-product plans for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderByProductPlanCount { get; set; }
        /// <summary>Shop order main</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderMain { get; set; }
        /// <summary>Shop order main number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderMainNumber { get; set; }
        /// <summary>Number of shop order material plans, which are backflushed, for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderMaterialPlanBackflushCount { get; set; }
        /// <summary>Number of shop order material plans for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderMaterialPlanCount { get; set; }
        /// <summary>Collection of Shop order Material plans</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Manufacturing.ShopOrderMaterialPlan> ShopOrderMaterialPlans { get; set; }
        /// <summary>Unique number to indentify the shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Unique number to indentify the shop order (as a string to allow OData filtering, e.g. $filter=substringof(&apos;123&apos;,ShopOrderNumberString) eq true</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShopOrderNumberString { get; set; }
        /// <summary>Shop order parent</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderParent { get; set; }
        /// <summary>Shop order parent number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderParentNumber { get; set; }
        /// <summary>Number of shop order routing step plans for this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 ShopOrderRoutingStepPlanCount { get; set; }
        /// <summary>Collection of Shop order Routing step plans</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<Manufacturing.ShopOrderRoutingStepPlan> ShopOrderRoutingStepPlans { get; set; }
        /// <summary>Indicates the type of Shop Order: 10 Open, 20 In process, 30 Finished, 40 Completed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Status { get; set; }
        /// <summary>The count of material lines of this shop order, which have been linked to a sub order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 SubShopOrderCount { get; set; }
        /// <summary>Overall status of the line: 9040 Regular</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Type { get; set; }
        /// <summary>Unit of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit description of the unit of the item created by this shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Reference to the Warehouse associated with the Shop order</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Your reference (of the customer)</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderMaterialPlan
    {
        /// <summary>Indicates if this is a backflush step</summary>
        public byte? Backflush { get; set; }
        /// <summary>Calculator type</summary>
        public Int32? CalculatorType { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the material</summary>
        public string Description { get; set; }
        /// <summary>Detail drawing reference</summary>
        public string DetailDrawing { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to Items table</summary>
        public Guid? Item { get; set; }
        /// <summary>Item Code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>URL of the material item&apos;s picture</summary>
        public string ItemPictureUrl { get; set; }
        /// <summary>Line number</summary>
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
        /// <summary>Line notes</summary>
        public string Notes { get; set; }
        /// <summary>Planned amount in the currency of the transaction</summary>
        public double? PlannedAmountFC { get; set; }
        /// <summary>Date that the material is required.</summary>
        public DateTime? PlannedDate { get; set; }
        /// <summary>Planned price of the material</summary>
        public double? PlannedPriceFC { get; set; }
        /// <summary>Intended quantity</summary>
        public double? PlannedQuantity { get; set; }
        /// <summary>Intended quantity unit factor</summary>
        public double? PlannedQuantityFactor { get; set; }
        /// <summary>Reference to ShopOrders table</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Line status</summary>
        public Int32? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Type</summary>
        public Int32? Type { get; set; }
        /// <summary>Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("StockTransactionId")]
    public class ShopOrderReceipt
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date of this ShopOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Serial or batch numbers are reserved prior to a POST to ShopOrderReceipts. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>Indicates if this ShopOrderReceipt has a quantity eligible to be reversed via ShopOrderReversals</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasReversibleQuantity { get; set; }
        /// <summary>Does the shop order receipt&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the shop order receipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Boolean indicating if this ShopOrderReceipt was part of an SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool IsIssueToParent { get; set; }
        /// <summary>Does the shop order receipt&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>Item finished</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item finished</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item finished</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of shop order item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Parent shop order if this ShopOrderReceipt is part of a SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ParentShopOrder { get; set; }
        /// <summary>Parent shop order number if this ShopOrderReceipt is part of a SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ParentShopOrderNumber { get; set; }
        /// <summary>Quantity of this ShopOrderReceipt</summary>
        public double? Quantity { get; set; }
        /// <summary>If this transaction was part of a SubOrderReceipt, this ID is the related MaterialIssue.StockTransactionID.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RelatedStockTransaction { get; set; }
        /// <summary>Shop order finished</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Number of shop order finished</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of stock transaction of this ShopOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid StockTransactionId { get; set; }
        /// <summary>ID of storage location finished to</summary>
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of storage location finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Effective date of this ShopOrderReceipt</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item finished</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of item finished</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse finished to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ReversalStockTransactionId")]
    public class ShopOrderReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date of this reversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Does the ShopOrderReversal&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ShopOrderReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the ShopOrderReversal&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>Item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of shop order item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Notes associated with this reversal</summary>
        public string Note { get; set; }
        /// <summary>ID of the original stock transaction, which was reversed</summary>
        public Guid? OriginalStockTransactionId { get; set; }
        /// <summary>Quantity reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Quantity { get; set; }
        /// <summary>ID of stock transaction related to this ShopOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ReversalStockTransactionId { get; set; }
        /// <summary>Shop order being reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>Number of shop order being reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>ID of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Effective date of this ShopOrderReversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderRoutingStepPlan
    {
        /// <summary>Reference to Account providing the Outsourced item</summary>
        public Guid? Account { get; set; }
        /// <summary>Account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Account number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountNumber { get; set; }
        /// <summary>Attended Percentage</summary>
        public double? AttendedPercentage { get; set; }
        /// <summary>Indicates if this is a backflush step</summary>
        public byte? Backflush { get; set; }
        /// <summary>Total cost / Shop order planned quantity</summary>
        public double? CostPerItem { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the operation</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Efficiency Percentage</summary>
        public double? EfficiencyPercentage { get; set; }
        /// <summary>Conversion factor type between Shop order Item and Subcontract purchase Unit</summary>
        public Int32? FactorType { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Sequential order of the operation</summary>
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
        /// <summary>Reference to Operations</summary>
        public Guid? Operation { get; set; }
        /// <summary>Code of the routing step operation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OperationCode { get; set; }
        /// <summary>Description of the operation step</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OperationDescription { get; set; }
        /// <summary>Reference to OperationResources</summary>
        public Guid? OperationResource { get; set; }
        /// <summary>Planned end date</summary>
        public DateTime? PlannedEndDate { get; set; }
        /// <summary>Planned run hours</summary>
        public double? PlannedRunHours { get; set; }
        /// <summary>Planned setup hours</summary>
        public double? PlannedSetupHours { get; set; }
        /// <summary>Planned start date</summary>
        public DateTime? PlannedStartDate { get; set; }
        /// <summary>Setup hours + Run hours</summary>
        public double? PlannedTotalHours { get; set; }
        /// <summary>Reference to Units</summary>
        public string PurchaseUnit { get; set; }
        /// <summary>Purchase Unit Factor</summary>
        public double? PurchaseUnitFactor { get; set; }
        /// <summary>Purchase Unit Price in the currency of the transaction</summary>
        public double? PurchaseUnitPriceFC { get; set; }
        /// <summary>Purchase unit quantity of the plan</summary>
        public double? PurchaseUnitQuantity { get; set; }
        /// <summary>Reference to RoutingStepTypes</summary>
        public Int32? RoutingStepType { get; set; }
        /// <summary>Used in conjunction with RunMethod, and EfficiencyPercentage to determine PlannedRunHours</summary>
        public double? Run { get; set; }
        /// <summary>Reference to OperationMethod</summary>
        public Int32? RunMethod { get; set; }
        /// <summary>Description of RunMethod</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RunMethodDescription { get; set; }
        /// <summary>Used in conjunction with SetupCount and Setup Unit to determine PlannedSetupHours</summary>
        public double? Setup { get; set; }
        /// <summary>Reference to TimeUnits</summary>
        public string SetupUnit { get; set; }
        /// <summary>Reference to Shop orders</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Reference to OperationStatus</summary>
        public Int32? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Subcontracted lead days</summary>
        public Int32? SubcontractedLeadDays { get; set; }
        /// <summary>Collection of TimeTransactions</summary>
        public IEnumerable<Manufacturing.TimeTransaction> TimeTransactions { get; set; }
        /// <summary>Total cost of the routing line</summary>
        public double? TotalCostDC { get; set; }
        /// <summary>Reference to Workcenters</summary>
        public Guid? Workcenter { get; set; }
        /// <summary>Workcenter code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WorkcenterCode { get; set; }
        /// <summary>Workcenter description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WorkcenterDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("Id")]
    public class StageForDeliveryReceipt
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date this Stage for delivery wa created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Indicates if this StageForDeliveryReceipt has a quantity eligible to be reversed via StageForDeliveryReversals</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasReversibleQuantity { get; set; }
        /// <summary>ID of staged for delivery entry</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Id { get; set; }
        /// <summary>Does the shop order receipt&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the stage for delivery receipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsFractionAllowedItem { get; set; }
        /// <summary>Does the shop order receipt&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsSerial { get; set; }
        /// <summary>Item staged for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item staged for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item staged for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of shop order item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Quantity of this StageForDeliveryReceipt</summary>
        public double? Quantity { get; set; }
        /// <summary>ID of the original stage for delivery entry</summary>
        public Guid? RelatedId { get; set; }
        /// <summary>Shop order staged for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ShopOrder { get; set; }
        /// <summary>Number of shop order staged for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Effective date of this stage for delivery receipt</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item finished</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of item finished</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("Id")]
    public class StageForDeliveryReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date of this reversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>ID of this StageForDeliveryReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid Id { get; set; }
        /// <summary>Does the shop order receipt&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the StageForDeliveryReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsFractionAllowedItem { get; set; }
        /// <summary>Does the shop order receipt&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte IsSerial { get; set; }
        /// <summary>Item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Quantity reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Quantity { get; set; }
        /// <summary>ID of the original stage for delivery entry, which is being reversed</summary>
        public Guid? RelatedId { get; set; }
        /// <summary>Shop order being reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>Number of shop order being reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Effective date of this StageForDeliveryReversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of the shop order warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ShopOrderReceiptStockTransactionId")]
    public class SubOrderReceipt
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Creation date of this SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Serial or batch numbers are reserved prior to a POST to SubOrderReceipt. This DraftStockTransactionID represents the group of serial or batch numbers to be used in this transaction.</summary>
        public Guid? DraftStockTransactionID { get; set; }
        /// <summary>Indicates if this SubOrderReceipt has a quantity eligible to be reversed via SubOrderReversals</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool HasReversibleQuantity { get; set; }
        /// <summary>Does the SubOrderReceipt&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the SubOrderReceipt&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>Item of this SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of this SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of this SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of shop order item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>MaterialIssue.StockTransactionId related to this SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? MaterialIssueStockTransactionId { get; set; }
        /// <summary>Shop order issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ParentShopOrder { get; set; }
        /// <summary>Shop order material plan issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ParentShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order issued to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ParentShopOrderNumber { get; set; }
        /// <summary>Quantity of this SubOrderReceipt</summary>
        public double? Quantity { get; set; }
        /// <summary>ShopOrderReceipt.StockTransactionId related to this SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ShopOrderReceiptStockTransactionId { get; set; }
        /// <summary>Shop order issued from</summary>
        public Guid? SubShopOrder { get; set; }
        /// <summary>Number of shop order issued from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SubShopOrderNumber { get; set; }
        /// <summary>Effective date of this SubOrderReceipt</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of this SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of this SubOrderReceipt&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse SubOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("MaterialReversalStockTransactionId")]
    public class SubOrderReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Creation date of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Does the SubOrderReversal&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the SubOrderReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the SubOrderReversal&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>Item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of shop order item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>MaterialReversal.StockTransactionId related to this SubOrderReversal&apos;s MaterialReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid MaterialReversalStockTransactionId { get; set; }
        /// <summary>Notes logged with this reversal</summary>
        public string Note { get; set; }
        /// <summary>MaterialIssue.StockTransactionId related to this SubOrderReceipt&apos;s original MaterialIssue</summary>
        public Guid? OriginalMaterialIssueStockTransactionId { get; set; }
        /// <summary>ShopOrderReceipt.StockTransactionId related to this SubOrderReceipt&apos;s original ShopOrderReceipt</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? OriginalShopOrderReceiptStockTransactionId { get; set; }
        /// <summary>Shop order reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ParentShopOrder { get; set; }
        /// <summary>Number of shop order reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ParentShopOrderNumber { get; set; }
        /// <summary>Quantity of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Quantity { get; set; }
        /// <summary>ShopOrderReversal.StockTransactionId related to this SubOrderReversal&apos;s ShopOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderReversalStockTransactionId { get; set; }
        /// <summary>Shop order reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SubShopOrder { get; set; }
        /// <summary>Number of shop order reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SubShopOrderNumber { get; set; }
        /// <summary>Effective date of this SubOrderReversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of this SubOrderReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of this SubOrderReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse of this SubOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeTransaction
    {
        /// <summary>Manufacturing time type: Setup = 10, Run = 20</summary>
        public Int32? Activity { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Date</summary>
        public DateTime? Date { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the transaction</summary>
        public Guid? Employee { get; set; }
        /// <summary>Machine hours</summary>
        public double? Hours { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Is the operation finished?</summary>
        public byte? IsOperationFinished { get; set; }
        /// <summary>Labor Hours on the operation</summary>
        public double? LaborHours { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Notes linked to the time transaction</summary>
        public string Notes { get; set; }
        /// <summary>Percentage of the operation that is complete</summary>
        public double? PercentComplete { get; set; }
        /// <summary>Quantity</summary>
        public double? Quantity { get; set; }
        /// <summary>Routing step linked to the transaction</summary>
        public Guid? RoutingStepPlan { get; set; }
        /// <summary>Shop order linked to the transaction</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Status of the transaction: Draft = 1, Rejected = 2, Submitted = 10, Final = 20</summary>
        public Int32? Status { get; set; }
        /// <summary>Timed time transaction linked to the transaction</summary>
        public Guid? TimedTimeTransaction { get; set; }
        /// <summary>Workcenter linked to the transaction</summary>
        public Guid? WorkCenter { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Workcenter
    {
        /// <summary>Code of the work center</summary>
        public string Code { get; set; }
        /// <summary>Reference to CostCenters</summary>
        public string Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        /// <summary>Reference to CostUnits</summary>
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
        /// <summary>Description of the work center</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>General burden rate</summary>
        public double? GeneralBurdenRate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if labor burden is calculated as a percentage or amount</summary>
        public byte IsLaborBurdenPercent { get; set; }
        /// <summary>Labor burden rate</summary>
        public double? LaborBurdenRate { get; set; }
        /// <summary>Machine burden rate</summary>
        public double? MachineBurdenRate { get; set; }
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
        public string Notes { get; set; }
        /// <summary>Area to which the work center belongs.</summary>
        public Guid? ProductionArea { get; set; }
        /// <summary>Run labor rate</summary>
        public double? RunLaborRate { get; set; }
        /// <summary>Search code of the work center</summary>
        public string SearchCode { get; set; }
        /// <summary>Setup labor rate</summary>
        public double? SetupLaborRate { get; set; }
        /// <summary>Reference to WorkcenterStatus</summary>
        public Int32? Status { get; set; }
        /// <summary>Reference to WorkcenterTypes</summary>
        public Int32? Type { get; set; }
    }
}
