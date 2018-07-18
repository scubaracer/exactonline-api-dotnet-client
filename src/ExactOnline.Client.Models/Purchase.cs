using System.Collections.Generic;
using System;

namespace Purchase
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class PurchaseInvoice
    {
        /// <summary>The amount including VAT in the currency of the invoice.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double Amount { get; set; }
        /// <summary>Guid identifying the contact person of the supplier.</summary>
        public Guid? ContactPerson { get; set; }
        /// <summary>The code of the currency of the invoiced amount.</summary>
        public string Currency { get; set; }
        /// <summary>The description of the invoice.</summary>
        public string Description { get; set; }
        /// <summary>Guid identifying a document that is attached to the invoice.</summary>
        public Guid? Document { get; set; }
        /// <summary>The date before which the invoice has to be paid.</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>The unique number of the purchase invoice. The entry number is based on a setting in the purchase journal and incremented for each new purchase invoice.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>The exchange rate between the invoice currency and the default currency of the division.</summary>
        public double? ExchangeRate { get; set; }
        /// <summary>The financial period in which the invoice is entered.</summary>
        public Int16? FinancialPeriod { get; set; }
        /// <summary>The financial year in which the invoice is entered.</summary>
        public Int16? FinancialYear { get; set; }
        /// <summary>A guid that is the unique identifier of the purchase invoice.</summary>
        public Guid ID { get; set; }
        /// <summary>The date on which the supplier entered the invoice.</summary>
        public DateTime? InvoiceDate { get; set; }
        /// <summary>The code of the purchase journal in which the invoice is entered.</summary>
        public string Journal { get; set; }
        /// <summary>The date and time the invoice was last modified.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>The code of the payment condition that is used to calculate the due date and discount.</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Unique reference to match payments and invoices.</summary>
        public string PaymentReference { get; set; }
        /// <summary>The collection of lines that belong to the purchase invoice.</summary>
        public IEnumerable<Purchase.PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
        /// <summary>The user can enter remarks related to the invoice here.</summary>
        public string Remarks { get; set; }
        /// <summary>Indicates the origin of the invoice. 1 Manual entry, 3 Purchase invoice, 4 Purchase order, 5 Web service.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Source { get; set; }
        /// <summary>The status of the invoice. 10 Draft, 20 Open, 50 Processed.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        /// <summary>Guid that identifies the supplier.</summary>
        public Guid? Supplier { get; set; }
        /// <summary>Indicates the type of the purchase invoice. 8030 Direct purchase invoice, 8031 Direct purchase invoice (Credit), 8033 Purchase invoice, 8034 Purchase invoice (Credit)</summary>
        public Int16 Type { get; set; }
        /// <summary>The total VAT amount of the purchase invoice.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATAmount { get; set; }
        /// <summary>Guid that identifies the warehouse that will receive the purchased goods. This is mandatory for creating a direct purchase invoice. </summary>
        public Guid? Warehouse { get; set; }
        /// <summary>The invoice number provided by the supplier.</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class PurchaseInvoiceLine
    {
        /// <summary>In a GET request the line amount is always returned excluding VAT.&lt;br&gt;&lt;br&gt;In a POST request the line amount has to be submitted either including or excluding the VAT amount. This depends on the type (including or excluding) of the VAT code.</summary>
        public double Amount { get; set; }
        /// <summary>The code of the cost center that is linked to this invoice line.</summary>
        public string CostCenter { get; set; }
        /// <summary>The code of the cost unit that is linked to this invoice line.</summary>
        public string CostUnit { get; set; }
        /// <summary>The currency of the line amount. The total invoice amount and all individual line amounts are in the same currency.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Currency { get; set; }
        /// <summary>Description of the invoice line.</summary>
        public string Description { get; set; }
        /// <summary>The discount given on the default price. A value of 0.1 translates to 10% discount.</summary>
        public double? Discount { get; set; }
        /// <summary>A guid that uniqely identifies the invoice line.</summary>
        public Guid ID { get; set; }
        /// <summary>The unique identifier of the purchase invoice this line belongs to.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? InvoiceID { get; set; }
        /// <summary>Guid that identifies the purchase item. In a POST request either the Item or the PurchaseOrderLine has to be supplied.</summary>
        public Guid? Item { get; set; }
        /// <summary>The default unit of the purchased item.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemUnit { get; set; }
        /// <summary>The sequence number of the line.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }
        /// <summary>The date and time the invoice line was last modified.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>The net price that has to be paid per unit. NetPrice = UnitPrice * (1.0 - Discount).&lt;br&gt;Depending on the type of the VAT code the net price is including or excluding VAT.</summary>
        public double NetPrice { get; set; }
        /// <summary>The user can enter notes related to the invoice line here.</summary>
        public string Notes { get; set; }
        /// <summary>The project linked to the purchase invoice line. This field is only applicable for Manufacturing and Professional Services.</summary>
        public Guid? Project { get; set; }
        /// <summary>Guid that identifies the purchase order line that is being invoiced. When doing a POST either the Item or the PurchaseOrderLine has to be supplied.&lt;br/&gt;The values of the purchase order line such as Quantity, Item and Amount will be copied to the purchase invoice line.</summary>
        public Guid? PurchaseOrderLine { get; set; }
        /// <summary>The number of purchased items in purchase units. The purchase unit is defined on the item card and it can also be found using the logistics/SupplierItem api endpoint.For divisible items the quantity can be a fractional number, otherwise it is an integer.</summary>
        public double? Quantity { get; set; }
        /// <summary>The number of purchased items in default units. An item has both a default unit and a purchase unit, for example piece and box with a box containing 12 pieces. The multiplication factor (12 in this example) between the default unit and purchase unit is maintained on the item card. When you GET a purchase invoice line for 1 box of items the field Quantity = 1 and QuantityInDefaultUnits = 12. </summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? QuantityInDefaultUnits { get; set; }
        /// <summary>The code of the unit in which the item is purchased. For example piece, box or kg. The value is taken from the purchase unit in the item card.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>The default purchase price per unit.&lt;br&gt;Depending on the type of the VAT code the unit price is including or excluding VAT.</summary>
        public double? UnitPrice { get; set; }
        /// <summary>The VAT amount of the invoice line.</summary>
        public double? VATAmount { get; set; }
        /// <summary>The VAT code used for the invoice line.</summary>
        public string VATCode { get; set; }
        /// <summary>The VAT percentage.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATPercentage { get; set; }
    }
}
