using System.Collections.Generic;
using System;

namespace Project
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class CostTransaction
    {
        /// <summary>Account linked to the transaction</summary>
        public Guid? Account { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>This property is obsolete. Use property &apos;AmountFC&apos; instead.</summary>
        public double? Amount { get; set; }
        /// <summary>Amount of the transaction in the currency of the transaction</summary>
        public double? AmountFC { get; set; }
        /// <summary>Attachment linked to the transaction (not mandatory)</summary>
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
        /// <summary>Entrynumber</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>Errortext, used for the backgroundjobs</summary>
        public string ErrorText { get; set; }
        /// <summary>Reference to ProjectWBS (work breakdown structure)</summary>
        public Guid? Expense { get; set; }
        /// <summary>Description of ProjectWBS</summary>
        public string ExpenseDescription { get; set; }
        /// <summary>Status of the transaction</summary>
        public Int16? HourStatus { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item linked to the transaction. Items of type &apos;time&apos; are linked to time transactionsItems of other types are linked to costtransactions</summary>
        public Guid? Item { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Indicates if fractional quantities of the item can be used, for example quantity = 0.4</summary>
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
        /// <summary>Notes linked to the transaction (not mandatory)</summary>
        public string Notes { get; set; }
        /// <summary>This property is obsolete. Use property &apos;PriceFC&apos; instead.</summary>
        public double? Price { get; set; }
        /// <summary>PriceFC (AmountFC = Quantity * PriceFC)</summary>
        public double? PriceFC { get; set; }
        /// <summary>Project linked to the transaction</summary>
        public Guid? Project { get; set; }
        /// <summary>Project account linked to the transaction (not mandatory)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ProjectAccount { get; set; }
        /// <summary>Project account code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountCode { get; set; }
        /// <summary>Project account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectAccountName { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Quantity of the transaction</summary>
        public double? Quantity { get; set; }
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

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class HourCostType
    {
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ItemId { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvoiceTerm
    {
        /// <summary>Amount in the currency of the transaction</summary>
        public double? Amount { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>WBS&apos;s deliverable linked to invoice term</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Deliverable { get; set; }
        /// <summary>Description of invoice term</summary>
        public string Description { get; set; }
        /// <summary>Division number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Execution date: From</summary>
        public DateTime? ExecutionFromDate { get; set; }
        /// <summary>Execution date: To</summary>
        public DateTime? ExecutionToDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Invoice date</summary>
        public DateTime? InvoiceDate { get; set; }
        /// <summary>Reference to item</summary>
        public Guid? Item { get; set; }
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
        /// <summary>Notes</summary>
        public string Notes { get; set; }
        /// <summary>Percentage of amount per project&apos;s budgeted amount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Percentage { get; set; }
        /// <summary>Reference to project</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Reference to VATCode</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
        /// <summary>VATCode percentage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? VATPercentage { get; set; }
    }

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

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ProjectBudgetType
    {
        /// <summary>Description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Int16 ID { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectHourBudget
    {
        /// <summary>Number of hours</summary>
        public double? Budget { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Hour type of budget</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of hour type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of hour type</summary>
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
        /// <summary>Reference to project</summary>
        public Guid Project { get; set; }
        /// <summary>Code of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectPlanning
    {
        /// <summary>Account linked to the project planning</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Status of the project planning process, 1 = To be processed, 2 = Processed, 3 = Failed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? BGTStatus { get; set; }
        /// <summary>Status of the external calendar, 0 = No error, 1 = Credentials error, 2 = Technical error, 3 = Both credentials &amp; technical errors, 4 = In progress</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? CommunicationErrorStatus { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of project planning</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the project planning</summary>
        public Guid? Employee { get; set; }
        /// <summary>Code of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeCode { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EmployeeHID { get; set; }
        /// <summary>End date of the project planning</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Hours of the project planning</summary>
        public double? Hours { get; set; }
        /// <summary>The type of hour for the project planning, item with &apos;Time&apos; type</summary>
        public Guid? HourType { get; set; }
        /// <summary>Code of the hour type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string HourTypeCode { get; set; }
        /// <summary>Description of the hour type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string HourTypeDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates whether the project planning is separated from the recurring planning</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? IsBrokenRecurrence { get; set; }
        /// <summary>Date modified</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Modifier user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Modifier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>For additional information about project planning</summary>
        public string Notes { get; set; }
        /// <summary>Indicates whether the entries can have over allocated planning hours</summary>
        public bool? OverAllocate { get; set; }
        /// <summary>Project linked to the planning</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Recurring planning linked to the project planning</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ProjectPlanningRecurring { get; set; }
        /// <summary>WBS linked to the project planning</summary>
        public Guid? ProjectWBS { get; set; }
        /// <summary>Description of WBS</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectWBSDescription { get; set; }
        /// <summary>Start date of the project planning</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Status of the project planning, 1 = Reserved, 2 = Planned</summary>
        public Int16? Status { get; set; }
        /// <summary>Type of the project planning, it will always is 4 (employee)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Type { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectPlanningRecurring
    {
        /// <summary>Account linked to the recurring planning</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Status of the project planning process, 1 = To be processed, 2 = Processed, 3 = Failed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? BGTStatus { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Indicates whether the recurring planning is day of the month or weekday of the month</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DayOrThe { get; set; }
        /// <summary>Description of recurring planning</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the recurring planning</summary>
        public Guid? Employee { get; set; }
        /// <summary>Code of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeCode { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EmployeeHID { get; set; }
        /// <summary>End date of the recurring planning</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Indicates whether the recurring planning is end on end date or end after number of times</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EndDateOrAfter { get; set; }
        /// <summary>End time for the recurring planning to be active</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Number of hours for the recurring planning</summary>
        public double? Hours { get; set; }
        /// <summary>Hour type of the recurring planning, item with &apos;Time&apos; type</summary>
        public Guid? HourType { get; set; }
        /// <summary>Code of the hour type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string HourTypeCode { get; set; }
        /// <summary>Description of the hour type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string HourTypeDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Date modified</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Modifier user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Modifier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Day of the monthly recurring</summary>
        public byte? MonthPatternDay { get; set; }
        /// <summary>Ordinal number of week day for the monthly recurring planning, 1 = first, 2 = second, 3 = third, 4 = fourth, 31 = last</summary>
        public byte? MonthPatternOrdinalDay { get; set; }
        /// <summary>Ordinal week day of the monthly recurring planning, 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday, 5 = Friday, 6 = Saturday, 7 = Sunday</summary>
        public byte? MonthPatternOrdinalWeek { get; set; }
        /// <summary>For additional information about recurring planning</summary>
        public string Notes { get; set; }
        /// <summary>Number of times the planning recurs</summary>
        public Int16? NumberOfRecurrences { get; set; }
        /// <summary>Indicates whether the entries can have over allocated planning hours</summary>
        public bool? OverAllocate { get; set; }
        /// <summary>Number of planning times for weekly or monthly recurring planning</summary>
        public byte? PatternFrequency { get; set; }
        /// <summary>Project linked to the recurring planning</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Description of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
        /// <summary>Type of the recurring planning, 1 = weekly, 2 = monthly</summary>
        public byte? ProjectPlanningRecurringType { get; set; }
        /// <summary>WBS linked to the recurring planning</summary>
        public Guid? ProjectWBS { get; set; }
        /// <summary>Description of WBS</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectWBSDescription { get; set; }
        /// <summary>Start date of the recurring planning</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Start time for the recurring planning to be active</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>Status of the project planning, 1 = Reserved, 2 = Planned</summary>
        public Int16? Status { get; set; }
        /// <summary>Week day for the weekly recurring planning</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? WeekPatternDay { get; set; }
        /// <summary>Create planning on Friday, apply to weekly pattern recurring planning only</summary>
        public bool? WeekPatternFriday { get; set; }
        /// <summary>Create planning on Monday, apply to weekly pattern recurring planning only</summary>
        public bool? WeekPatternMonday { get; set; }
        /// <summary>Create planning on Saturday, apply to weekly pattern recurring planning only</summary>
        public bool? WeekPatternSaturday { get; set; }
        /// <summary>Create planning on Sunday, apply to weekly pattern recurring planning only</summary>
        public bool? WeekPatternSunday { get; set; }
        /// <summary>Create planning on Thursday, apply to weekly pattern recurring planning only</summary>
        public bool? WeekPatternThursday { get; set; }
        /// <summary>Create planning on Tuesday, apply to weekly pattern recurring planning only</summary>
        public bool? WeekPatternTuesday { get; set; }
        /// <summary>Create planning on Wednesday, apply to weekly pattern recurring planning only</summary>
        public bool? WeekPatternWednesday { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionEmployee
    {
        /// <summary>Date created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>Creator user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Creator name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the restriction</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }
        /// <summary>Readable ID of the employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EmployeeHID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Date modified</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Modifier user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Modifier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Project linked to the restriction</summary>
        public Guid? Project { get; set; }
        /// <summary>Project code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Project description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionItem
    {
        /// <summary>Date created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>Creator user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Creator name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item linked to the restriction</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of the item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Indicates if the item is a time unit item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? ItemIsTime { get; set; }
        /// <summary>Date modified</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Modifier user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Modifier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Project linked to the restriction</summary>
        public Guid? Project { get; set; }
        /// <summary>Project code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Project description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionRebilling
    {
        /// <summary>Cost type reference</summary>
        public Guid? CostTypeRebill { get; set; }
        /// <summary>Cost type code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostTypeRebillCode { get; set; }
        /// <summary>Cost type description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostTypeRebillDescription { get; set; }
        /// <summary>Date created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>Creator user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Creator name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Date modified</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Modifier user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Modifier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Project linked to the restriction</summary>
        public Guid? Project { get; set; }
        /// <summary>Project code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }
        /// <summary>Project description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentCost
    {
        /// <summary>Code of Account</summary>
        public string AccountCode { get; set; }
        /// <summary>Reference to Account</summary>
        public Guid? AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public string AccountName { get; set; }
        /// <summary>Amount approved</summary>
        public double AmountApproved { get; set; }
        /// <summary>Amount draft</summary>
        public double AmountDraft { get; set; }
        /// <summary>Amount rejected</summary>
        public double AmountRejected { get; set; }
        /// <summary>Amount submitted</summary>
        public double AmountSubmitted { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Date</summary>
        public DateTime Date { get; set; }
        /// <summary>Entry ID</summary>
        public Guid? EntryId { get; set; }
        /// <summary>Reference to Expense</summary>
        public Guid? Expense { get; set; }
        /// <summary>Description of Expense</summary>
        public string ExpenseDescription { get; set; }
        /// <summary>Primary key</summary>
        public Int32 Id { get; set; }
        /// <summary>Code of Item</summary>
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        public string ItemDescription { get; set; }
        /// <summary>Reference to Item</summary>
        public Guid? ItemId { get; set; }
        /// <summary>Remarks</summary>
        public string Notes { get; set; }
        /// <summary>Code of Project</summary>
        public string ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        public string ProjectDescription { get; set; }
        /// <summary>Reference to Project</summary>
        public Guid? ProjectId { get; set; }
        /// <summary>Quantity approved</summary>
        public double QuantityApproved { get; set; }
        /// <summary>Quantity draft</summary>
        public double QuantityDraft { get; set; }
        /// <summary>Quantity rejected</summary>
        public double QuantityRejected { get; set; }
        /// <summary>Quantity submitted</summary>
        public double QuantitySubmitted { get; set; }
        /// <summary>Week number</summary>
        public Int32 WeekNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentHour
    {
        /// <summary>Code of Account</summary>
        public string AccountCode { get; set; }
        /// <summary>Reference to Account</summary>
        public Guid? AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public string AccountName { get; set; }
        /// <summary>Reference to Activity</summary>
        public Guid? Activity { get; set; }
        /// <summary>Description of Activity</summary>
        public string ActivityDescription { get; set; }
        /// <summary>Date</summary>
        public DateTime Date { get; set; }
        /// <summary>Entry ID</summary>
        public Guid? EntryId { get; set; }
        /// <summary>Hours approved</summary>
        public double HoursApproved { get; set; }
        /// <summary>Billable hours approved</summary>
        public double HoursApprovedBillable { get; set; }
        /// <summary>Hours draft</summary>
        public double HoursDraft { get; set; }
        /// <summary>Billable hours draft</summary>
        public double HoursDraftBillable { get; set; }
        /// <summary>Hours rejected</summary>
        public double HoursRejected { get; set; }
        /// <summary>Billable hours rejected</summary>
        public double HoursRejectedBillable { get; set; }
        /// <summary>Hours submitted</summary>
        public double HoursSubmitted { get; set; }
        /// <summary>Billable hours submitted</summary>
        public double HoursSubmittedBillable { get; set; }
        /// <summary>Primary key</summary>
        public Int32 Id { get; set; }
        /// <summary>Code of Item</summary>
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        public string ItemDescription { get; set; }
        /// <summary>Reference to Item</summary>
        public Guid? ItemId { get; set; }
        /// <summary>Remarks</summary>
        public string Notes { get; set; }
        /// <summary>Code of Project</summary>
        public string ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        public string ProjectDescription { get; set; }
        /// <summary>Reference to Project</summary>
        public Guid? ProjectId { get; set; }
        /// <summary>Week number</summary>
        public Int32 WeekNumber { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingAccountDetail
    {
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Name</summary>
        public string Name { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingActivitiesAndExpens
    {
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Description of Parent</summary>
        public string ParentDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingEntryAccount
    {
        /// <summary>Primary key</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of account</summary>
        public string AccountName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingEntryProject
    {
        /// <summary>Code</summary>
        public string ProjectCode { get; set; }
        /// <summary>Description</summary>
        public string ProjectDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ProjectId { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingEntryRecentAccount
    {
        /// <summary>Primary key</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of account</summary>
        public string AccountName { get; set; }
        /// <summary>Date last used</summary>
        public DateTime DateLastUsed { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingEntryRecentActivitiesAndExpens
    {
        /// <summary>Date last used</summary>
        public DateTime DateLastUsed { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Description of Parent</summary>
        public string ParentDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class TimeAndBillingEntryRecentHourCostType
    {
        /// <summary>Date last used</summary>
        public DateTime DateLastUsed { get; set; }
        /// <summary>Description of item</summary>
        public string ItemDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ItemId { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingEntryRecentProject
    {
        /// <summary>Date last used</summary>
        public DateTime DateLastUsed { get; set; }
        /// <summary>Code of project</summary>
        public string ProjectCode { get; set; }
        /// <summary>Description of project</summary>
        public string ProjectDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ProjectId { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingItemDetail
    {
        /// <summary>Item code</summary>
        public string Code { get; set; }
        /// <summary>Description of the item code</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if fractions are allowed for quantities of this item</summary>
        public bool IsFractionAllowedItem { get; set; }
        /// <summary>Indicates if the item can be sold</summary>
        public bool IsSalesItem { get; set; }
        /// <summary>Sales currency code</summary>
        public string SalesCurrency { get; set; }
        /// <summary>Sales price</summary>
        public double SalesPrice { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingProjectDetail
    {
        /// <summary>The account for this project</summary>
        public Guid? Account { get; set; }
        public string AccountName { get; set; }
        /// <summary>Code of project</summary>
        public string Code { get; set; }
        /// <summary>Description of the project</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to ProjectTypes</summary>
        public Int32 Type { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeCorrection
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
        /// <summary>Id</summary>
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
        /// <summary>Reference to the time entry that this corrects for</summary>
        public Guid? OriginalEntryId { get; set; }
        /// <summary>Quantity has to be negative value. E.g.: If original quantity is 10 and the correct quantity is 4, this quantity is -6</summary>
        public double? Quantity { get; set; }
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
