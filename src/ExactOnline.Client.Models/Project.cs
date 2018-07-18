using System.Collections.Generic;
using System;

namespace Project
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Project
    {
        /// <summary>The account for this project</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Contact person of Account</summary>
        public Guid? AccountContact { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Is additional invoice is allowed for project</summary>
        public bool? AllowAdditionalInvoicing { get; set; }
        /// <summary>Block time and cost entries</summary>
        public bool? BlockEntry { get; set; }
        /// <summary>Block rebilling</summary>
        public bool? BlockRebilling { get; set; }
        /// <summary>Budgeted amount of sales in the default currency of the company</summary>
        public double? BudgetedAmount { get; set; }
        /// <summary>Budgeted amount of costs in the default currency of the company</summary>
        public double? BudgetedCosts { get; set; }
        /// <summary>Collection of budgeted hours</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectHourBudget> BudgetedHoursPerHourType { get; set; }
        /// <summary>Budgeted amount of revenue in the default currency of the company</summary>
        public double? BudgetedRevenue { get; set; }
        /// <summary>Budget type</summary>
        public Int16? BudgetType { get; set; }
        /// <summary>Budget type description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetTypeDescription { get; set; }
        /// <summary>Used only for PSA to link a project classification to the project</summary>
        public Guid? Classification { get; set; }
        /// <summary>Description of Classification</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }
        /// <summary>Code</summary>
        public string Code { get; set; }
        /// <summary>Used only for PSA to store the budgetted costs of a project (except for project type Campaign and Non-billable). Positive quantities only</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? CostsAmountFC { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Used only for PSA to store the customer&apos;s PO number</summary>
        public string CustomerPOnumber { get; set; }
        /// <summary>Description of the project</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Name of Division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionName { get; set; }
        /// <summary>End date of the project. In combination with the start date the status is determined</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Item used for fixed price invoicing. To be defined per project. If empty the functionality relies on the setting</summary>
        public Guid? FixedPriceItem { get; set; }
        /// <summary>Description of FixedPriceItem</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string FixedPriceItemDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Is invoice as quoted</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool InvoiceAsQuoted { get; set; }
        /// <summary>Collection of invoice terms</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<InvoiceTerm> InvoiceTerms { get; set; }
        /// <summary>Responsible person for this project</summary>
        public Guid? Manager { get; set; }
        /// <summary>Name of Manager</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ManagerFullname { get; set; }
        /// <summary>Purchase markup percentage</summary>
        public double? MarkupPercentage { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>For additional information about projects</summary>
        public string Notes { get; set; }
        /// <summary>Used only for PSA. This item is used for prepaid invoicing. If left empty, the functionality relies on a setting</summary>
        public Guid? PrepaidItem { get; set; }
        /// <summary>Description of PrepaidItem</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PrepaidItemDescription { get; set; }
        /// <summary>PrepaidType: 1-Retainer, 2-Hour type bundle</summary>
        public Int16? PrepaidType { get; set; }
        /// <summary>Description of PrepaidType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PrepaidTypeDescription { get; set; }
        /// <summary>Collection of employee restrictions</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionEmployee> ProjectRestrictionEmployees { get; set; }
        /// <summary>Collection of item restrictions</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionItem> ProjectRestrictionItems { get; set; }
        /// <summary>Collection of rebilling restrictions</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionRebilling> ProjectRestrictionRebillings { get; set; }
        /// <summary>Budgeted time. Total number of hours estimated for the fixed price project</summary>
        public double? SalesTimeQuantity { get; set; }
        /// <summary>Source quotation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SourceQuotation { get; set; }
        /// <summary>Start date of a project. In combination with the end date the status is determined</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Alert when exceeding (Hours)</summary>
        public double? TimeQuantityToAlert { get; set; }
        /// <summary>Reference to ProjectTypes</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>Using billing milestones</summary>
        public bool? UseBillingMilestones { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeTransaction
    {
        /// <summary>Account linked to the transaction</summary>
        public Guid? Account { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Reference to ProjectWBS (work breakdown structure)</summary>
        public Guid? Activity { get; set; }
        /// <summary>Description of ProjectWBS</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ActivityDescription { get; set; }
        /// <summary>This property is obsolete. Use property &apos;AmountFC&apos; instead.</summary>
        public double? Amount { get; set; }
        /// <summary>Amount in the currency of the transaction of the transaction</summary>
        public double? AmountFC { get; set; }
        /// <summary>Attachment linked to the transaction</summary>
        public Guid? Attachment { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Currency of the amount</summary>
        public string Currency { get; set; }
        /// <summary>Date</summary>
        public DateTime? Date { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Description of Division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }
        /// <summary>Employee linked to the transaction</summary>
        public Guid? Employee { get; set; }
        /// <summary>End time of the transaction</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Entrynumber</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>Errortext, used for the backgroundjobs</summary>
        public string ErrorText { get; set; }
        /// <summary>Status of the transaction</summary>
        public Int16? HourStatus { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item linked to the transaction. Items of type &apos;time&apos; are linked to time transactions. Items of other types are linked to cost transactions</summary>
        public Guid? Item { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>True if you can use decimals for item quantity</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Notes linked to the transaction</summary>
        public string Notes { get; set; }
        /// <summary>This property is obsolete. Use property &apos;PriceFC&apos; instead.</summary>
        public double? Price { get; set; }
        /// <summary>PriceFC (AmountFC = Quantity * PriceFC)</summary>
        public double? PriceFC { get; set; }
        /// <summary>Project linked to the transaction</summary>
        public Guid? Project { get; set; }
        /// <summary>Reference to project account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ProjectAccount { get; set; }
        /// <summary>Project account code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountCode { get; set; }
        /// <summary>Project account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountName { get; set; }
        /// <summary>Code of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Quantity of the transaction</summary>
        public double? Quantity { get; set; }
        /// <summary>Start time of the transaction</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>Subscription linked to the transaction</summary>
        public Guid? Subscription { get; set; }
        /// <summary>Account linked to the subscription</summary>
        public Guid? SubscriptionAccount { get; set; }
        /// <summary>Subscription account code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountCode { get; set; }
        /// <summary>Subscription account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountName { get; set; }
        /// <summary>Description of the subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }
        /// <summary>Subscription number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? SubscriptionNumber { get; set; }
        /// <summary>Type of the transaction</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Type { get; set; }
    }
}
