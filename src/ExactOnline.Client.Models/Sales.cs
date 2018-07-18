using System;

namespace Sales
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PriceList
    {
        /// <summary>Code to indicate the price list</summary>
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
        /// <summary>All prices in the price list are stored in this currency</summary>
        public string Currency { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Description of Division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }
        /// <summary>Indicates the entity (Item, Item group, ..) on which this price list is based</summary>
        public Int16? Entity { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Explanation or extra information can be stored in the notes</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SalesPriceListDetail
    {
        /// <summary>Customer account Id</summary>
        public Guid? Account { get; set; }
        /// <summary>Customer account name</summary>
        public string AccountName { get; set; }
        /// <summary>Standard price</summary>
        public Guid? BasePrice { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency</summary>
        public string Currency { get; set; }
        /// <summary>Discount</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>End date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Indicates whether discount or the new price is leading : 1-Discount, 2-New price. &lt;br&gt;&lt;br&gt; Scenario &lt;br&gt;&lt;br&gt; 1. When entry method is Discount and use base price, Discounted price = (1- SalesPriceListDetails.Discount) * SalesPriceListDetails.BasePrice &lt;br&gt;&lt;br&gt; 2. When entry method is Discount and use Item&apos;s standard sales price, Discounted price = (1- SalesPriceListDetails.Discount) * SalesItemPrices.Price &lt;br&gt;&lt;br&gt; 3. When entry method is New price, Discounted price = SalesPriceListDetails.NewPrice</summary>
        public Int16 EntryMethod { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item</summary>
        public Guid? Item { get; set; }
        /// <summary>Description of the item</summary>
        public string ItemDescription { get; set; }
        /// <summary>ItemGroup</summary>
        public Guid? ItemGroup { get; set; }
        /// <summary>Default sales unit of the item</summary>
        public string ItemUnit { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>New price after discount</summary>
        public double? NewPrice { get; set; }
        /// <summary>Number of the item per unit</summary>
        public double? NumberOfItemsPerUnit { get; set; }
        /// <summary>Code of the PriceList</summary>
        public string PriceListCode { get; set; }
        /// <summary>Id of the PriceList</summary>
        public Guid? PriceListId { get; set; }
        /// <summary>Quantity</summary>
        public double? Quantity { get; set; }
        /// <summary>Start date</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Unit</summary>
        public string Unit { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ShippingMethod
    {
        /// <summary>Active</summary>
        public bool? Active { get; set; }
        /// <summary>Code of the shipping method</summary>
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
        /// <summary>Description of shipping method</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
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
        /// <summary>Shipping method rates URL</summary>
        public string ShippingRatesURL { get; set; }
        /// <summary>Tracking URL</summary>
        public string TrackingURL { get; set; }
    }
}
