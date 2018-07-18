using System;

namespace Logistics
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Item
    {
        /// <summary>Barcode of the item (numeric string)</summary>
        public string Barcode { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 1</summary>
        public string Class_01 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 2</summary>
        public string Class_02 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 3</summary>
        public string Class_03 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 4</summary>
        public string Class_04 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 5</summary>
        public string Class_05 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 6</summary>
        public string Class_06 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 7</summary>
        public string Class_07 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 8</summary>
        public string Class_08 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 9</summary>
        public string Class_09 { get; set; }
        /// <summary>Item class code referring to ItemClasses with ClassID 10</summary>
        public string Class_10 { get; set; }
        /// <summary>Item code</summary>
        public string Code { get; set; }
        /// <summary>Copy sales remarks to sales lines</summary>
        public byte CopyRemarks { get; set; }
        /// <summary>The currency of the current and proposed cost price</summary>
        public string CostPriceCurrency { get; set; }
        /// <summary>Proposed cost price</summary>
        public double? CostPriceNew { get; set; }
        /// <summary>The current standard cost price</summary>
        public double? CostPriceStandard { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the item</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Together with StartDate this determines if the item is active</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Extra description text, slightly longer than the regular description (255 instead of 60)</summary>
        public string ExtraDescription { get; set; }
        /// <summary>Free boolean field 1</summary>
        public bool? FreeBoolField_01 { get; set; }
        /// <summary>Free boolean field 2</summary>
        public bool? FreeBoolField_02 { get; set; }
        /// <summary>Free boolean field 3</summary>
        public bool? FreeBoolField_03 { get; set; }
        /// <summary>Free boolean field 4</summary>
        public bool? FreeBoolField_04 { get; set; }
        /// <summary>Free boolean field 5</summary>
        public bool? FreeBoolField_05 { get; set; }
        /// <summary>Free date field 1</summary>
        public DateTime? FreeDateField_01 { get; set; }
        /// <summary>Free date field 2</summary>
        public DateTime? FreeDateField_02 { get; set; }
        /// <summary>Free date field 3</summary>
        public DateTime? FreeDateField_03 { get; set; }
        /// <summary>Free date field 4</summary>
        public DateTime? FreeDateField_04 { get; set; }
        /// <summary>Free date field 5</summary>
        public DateTime? FreeDateField_05 { get; set; }
        /// <summary>Free numeric field 1</summary>
        public double? FreeNumberField_01 { get; set; }
        /// <summary>Free numeric field 2</summary>
        public double? FreeNumberField_02 { get; set; }
        /// <summary>Free numeric field 3</summary>
        public double? FreeNumberField_03 { get; set; }
        /// <summary>Free numeric field 4</summary>
        public double? FreeNumberField_04 { get; set; }
        /// <summary>Free numeric field 5</summary>
        public double? FreeNumberField_05 { get; set; }
        /// <summary>Free numeric field 6</summary>
        public double? FreeNumberField_06 { get; set; }
        /// <summary>Free numeric field 7</summary>
        public double? FreeNumberField_07 { get; set; }
        /// <summary>Free numeric field 8</summary>
        public double? FreeNumberField_08 { get; set; }
        /// <summary>Free text field 1</summary>
        public string FreeTextField_01 { get; set; }
        /// <summary>Free text field 2</summary>
        public string FreeTextField_02 { get; set; }
        /// <summary>Free text field 3</summary>
        public string FreeTextField_03 { get; set; }
        /// <summary>Free text field 4</summary>
        public string FreeTextField_04 { get; set; }
        /// <summary>Free text field 5</summary>
        public string FreeTextField_05 { get; set; }
        /// <summary>Free text field 6</summary>
        public string FreeTextField_06 { get; set; }
        /// <summary>Free text field 7</summary>
        public string FreeTextField_07 { get; set; }
        /// <summary>Free text field 8</summary>
        public string FreeTextField_08 { get; set; }
        /// <summary>Free text field 9</summary>
        public string FreeTextField_09 { get; set; }
        /// <summary>Free text field 10</summary>
        public string FreeTextField_10 { get; set; }
        /// <summary>GL account the cost entries will be booked on. This overrules the GL account from the item group. If the license contains &apos;Intuit integration&apos; this property overrides the value in Settings, not the item group.</summary>
        public Guid? GLCosts { get; set; }
        /// <summary>Code of GL account for costs</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsCode { get; set; }
        /// <summary>Description of GLCosts</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsDescription { get; set; }
        /// <summary>GL account the revenue will be booked on. This overrules the GL account from the item group. If the license contains &apos;Intuit integration&apos; this property overrides the value in Settings, not the item group.</summary>
        public Guid? GLRevenue { get; set; }
        /// <summary>Code of GLRevenue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueCode { get; set; }
        /// <summary>Description of GLRevenue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueDescription { get; set; }
        /// <summary>GL account the stock entries will be booked on. This overrules the GL account from the item group. If the license contains &apos;Intuit integration&apos; this property overrides the value in Settings, not the item group.</summary>
        public Guid? GLStock { get; set; }
        /// <summary>Code of GL account for stock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockCode { get; set; }
        /// <summary>Description of GLStock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockDescription { get; set; }
        /// <summary>Gross weight for international goods shipments</summary>
        public double? GrossWeight { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if batches are used for this item</summary>
        public byte IsBatchItem { get; set; }
        /// <summary>This property is obsolete. Use property &apos;IsBatchItem&apos; instead.</summary>
        public byte IsBatchNumberItem { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of this item</summary>
        public bool? IsFractionAllowedItem { get; set; }
        /// <summary>Indicates that an Item is produced to Inventory, not purchased</summary>
        public byte IsMakeItem { get; set; }
        /// <summary>Only used for packages (IsPackageItem=1). To indicate if this package is a new contract type package</summary>
        public byte IsNewContract { get; set; }
        /// <summary>Is On demand Item</summary>
        public byte IsOnDemandItem { get; set; }
        /// <summary>Indicates if the item is a package item. Can only be created in the hosting administration</summary>
        public bool? IsPackageItem { get; set; }
        /// <summary>Indicates if the item can be purchased</summary>
        public bool? IsPurchaseItem { get; set; }
        /// <summary>Indicated if the item is used in voucher functionality</summary>
        public byte IsRegistrationCodeItem { get; set; }
        /// <summary>Indicates if the item can be sold</summary>
        public bool? IsSalesItem { get; set; }
        /// <summary>Indicates that serial numbers are used for this item</summary>
        public bool? IsSerialItem { get; set; }
        /// <summary>This property is obsolete. Use property &apos;IsSerialItem&apos; instead.</summary>
        public bool? IsSerialNumberItem { get; set; }
        /// <summary>If you have the Trade or Manufacturing license and you check this property the item will be shown in the stock positions overview, stock counts and transaction lists. If you have the Invoice module and you check this property you will get a general journal entry based on the Stock and Costs G/L accounts of the item group. If you don’t want the general journal entry to be created you should change the Stock/Costs G/L account on the Item group page to the type Costs instead of Inventory.</summary>
        public bool? IsStockItem { get; set; }
        /// <summary>Indicates if the item is provided by an outside supplier</summary>
        public bool? IsSubcontractedItem { get; set; }
        /// <summary>Indicates if tax needs to be calculated for this item</summary>
        public byte? IsTaxableItem { get; set; }
        /// <summary>Indicates if the item is a time unit item (for example a labor hour item)</summary>
        public byte IsTime { get; set; }
        /// <summary>Indicates if the item can be exported to a web shop</summary>
        public byte IsWebshopItem { get; set; }
        /// <summary>GUID of Item group of the item</summary>
        public Guid? ItemGroup { get; set; }
        /// <summary>Code of ItemGroup</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemGroupCode { get; set; }
        /// <summary>Description of ItemGroup</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemGroupDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Net weight for international goods shipments</summary>
        public double? NetWeight { get; set; }
        /// <summary>Net Weight unit for international goods shipment, only available in manufacturing packages</summary>
        public string NetWeightUnit { get; set; }
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>File name of picture</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureName { get; set; }
        /// <summary>Url where thumbnail picture can be retrieved</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }
        /// <summary>Url where picture can be retrieved</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }
        /// <summary>Code of SalesVat</summary>
        public string SalesVatCode { get; set; }
        /// <summary>Description of SalesVatCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SalesVatCodeDescription { get; set; }
        /// <summary>Search code of the item</summary>
        public string SearchCode { get; set; }
        /// <summary>Security level (0 - 100)</summary>
        public Int32? SecurityLevel { get; set; }
        /// <summary>Together with EndDate this determines if the item is active</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Quantity that is in stock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Stock { get; set; }
        /// <summary>The standard unit of this item</summary>
        public string Unit { get; set; }
        /// <summary>Description of Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Type of unit: A=Area, L=Length, O=Other, T=Time, V=Volume, W=Weight</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitType { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemGroup
    {
        /// <summary>Code of the item group</summary>
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
        /// <summary>Description of the item group</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>GL account on which the costs of items of this group will be booked</summary>
        public Guid? GLCosts { get; set; }
        /// <summary>Code of GLCosts</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsCode { get; set; }
        /// <summary>Description of GLCosts</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLCostsDescription { get; set; }
        /// <summary>GL Purchase account for purchase invoicing according to (non-) perpetual inventory method</summary>
        public Guid? GLPurchaseAccount { get; set; }
        /// <summary>Code of GLPurchase</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchaseAccountCode { get; set; }
        /// <summary>Description of GLPurchaseAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchaseAccountDescription { get; set; }
        /// <summary>GL account that will be used for the &apos;Standard cost price&apos; valuation method to balance the difference between purchase price and cost price</summary>
        public Guid? GLPurchasePriceDifference { get; set; }
        /// <summary>Code of GLPurchasePriceDifference</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchasePriceDifferenceCode { get; set; }
        /// <summary>Description of GLPurchasePriceDifference</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLPurchasePriceDifferenceDescr { get; set; }
        /// <summary>GL account on which the revenue for items of this group will be booked</summary>
        public Guid? GLRevenue { get; set; }
        /// <summary>Code of GLRevenue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueCode { get; set; }
        /// <summary>Description of GLRevenue</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLRevenueDescription { get; set; }
        /// <summary>GL account on which stock entries will be booked for items of this group</summary>
        public Guid? GLStock { get; set; }
        /// <summary>Code of GLStock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockCode { get; set; }
        /// <summary>Description of GLStock</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockDescription { get; set; }
        /// <summary>GL stock variance account for perpetual inventory</summary>
        public Guid? GLStockVariance { get; set; }
        /// <summary>Code of GLStockVariance</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockVarianceCode { get; set; }
        /// <summary>Description of GLStockVariance</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLStockVarianceDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the default item group that will be assigned when a new item is created</summary>
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
        /// <summary>Notes</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemVersion
    {
        /// <summary>Batch Quantity of Item Version</summary>
        public double? BatchQuantity { get; set; }
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
        /// <summary>Lead time of Item version</summary>
        public Int32? LeadTime { get; set; }
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
        /// <summary>Version Number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? VersionNumber { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesItemPrice
    {
        /// <summary>ID of the customer</summary>
        public Guid? Account { get; set; }
        /// <summary>Name of the customer account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>The currency of the price</summary>
        public string Currency { get; set; }
        /// <summary>The default unit of the item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DefaultItemUnit { get; set; }
        /// <summary>The description of the default item unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DefaultItemUnitDescription { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Together with StartDate this determines whether the price is active</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item ID</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
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
        /// <summary>This is the multiplication factor when going from default item unit to the unit of this price.For example if the default item unit is &apos;gram&apos; and the price unit is &apos;kilogram&apos; then the value of this property is 1000.</summary>
        public double? NumberOfItemsPerUnit { get; set; }
        /// <summary>The actual price of this sales item</summary>
        public double? Price { get; set; }
        /// <summary>Minimum quantity to which the price is applicable</summary>
        public double? Quantity { get; set; }
        /// <summary>Together with EndDate this determines whether the price is active</summary>
        public DateTime StartDate { get; set; }
        /// <summary>The unit code of the price</summary>
        public string Unit { get; set; }
        /// <summary>Description of the price unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SupplierItem
    {
        /// <summary>Country of origin code</summary>
        public string CountryOfOrigin { get; set; }
        /// <summary>Description of country of origin</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryOfOriginDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency of item price</summary>
        public string Currency { get; set; }
        /// <summary>Description of currency of item price</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Indicates that the supplier will deliver the item directly to customer. Values: 0 = No, 1 = Yes, 2 = Optional</summary>
        public byte? DropShipment { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item ID</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Indicates this is a main supplier</summary>
        public bool? MainSupplier { get; set; }
        /// <summary>Minimum quantity of the item for purchase, only available for Wholesale &amp; Distribution (Premium only)</summary>
        public double? MinimumQuantity { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>The number of days between placing an order with a supplier and receiving items from the supplier</summary>
        public Int32? PurchaseLeadTime { get; set; }
        /// <summary>Purchase price</summary>
        public double? PurchasePrice { get; set; }
        /// <summary>Unit code</summary>
        public string PurchaseUnit { get; set; }
        /// <summary>Description of unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseUnitDescription { get; set; }
        /// <summary>This is the multiplication factor when going from default item unit to the unit of this price</summary>
        public double? PurchaseUnitFactor { get; set; }
        /// <summary>VAT code</summary>
        public string PurchaseVATCode { get; set; }
        /// <summary>Description of VAT</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PurchaseVATCodeDescription { get; set; }
        /// <summary>Supplier ID</summary>
        public Guid? Supplier { get; set; }
        /// <summary>Supplier code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierCode { get; set; }
        /// <summary>Description of supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierDescription { get; set; }
        /// <summary>Supplier’s item code</summary>
        public string SupplierItemCode { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Unit
    {
        /// <summary>Indicates whether a unit is in use</summary>
        public bool? Active { get; set; }
        /// <summary>Unique code for the unit</summary>
        public string Code { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates the main unit per division. Will be used when creating new item</summary>
        public byte? Main { get; set; }
        /// <summary>If Type = &apos;T&apos; (time) then this fields indicates the type of time frame. yy = Year, mm = Month, wk = Week, dd = Day, hh = Hour, mi = Minute, ss = Second</summary>
        public string TimeUnit { get; set; }
        /// <summary>Type of unit. Type &apos;Time&apos; is especially important for contracts.</summary>
        public string Type { get; set; }
    }
}
