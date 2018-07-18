using System.Collections.Generic;
using System;

namespace HRM
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AbsenceRegistration
    {
        /// <summary>Collection of absence registration transactions</summary>
        public IEnumerable<HRM.AbsenceRegistrationTransaction> AbsenceRegistrationTransactions { get; set; }
        /// <summary>Absence cause, only supported for the Netherland legislation</summary>
        public Int16? Cause { get; set; }
        /// <summary>Code for the absence cause, only supported for the Netherland legislation</summary>
        public string CauseCode { get; set; }
        /// <summary>Description for the absence cause, only supported for the Netherland legislation</summary>
        public string CauseDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Employee linked to the absence</summary>
        public Guid Employee { get; set; }
        /// <summary>Employee full name</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32 EmployeeHID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Absence kind, only supported for the Netherland legislation</summary>
        public Int16? Kind { get; set; }
        /// <summary>Code for the absence kind, only supported for the Netherland legislation</summary>
        public string KindCode { get; set; }
        /// <summary>Description for the absence kind, only supported for the Netherland legislation</summary>
        public string KindDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Extra information for absence</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AbsenceRegistrationTransaction
    {
        /// <summary>Reference key to Absence Registration</summary>
        public Guid AbsenceRegistration { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>End time on the last day of absence stored as DateTime, and the date should be ignored</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Expected end date of absence</summary>
        public DateTime? ExpectedEndDate { get; set; }
        /// <summary>Total number of absence hours</summary>
        public double Hours { get; set; }
        /// <summary>Hours of absence on the first day</summary>
        public double? HoursFirstDay { get; set; }
        /// <summary>Hours of absence on the last day</summary>
        public double? HoursLastDay { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Extra information for absence</summary>
        public string Notes { get; set; }
        /// <summary>Notification moment of absence</summary>
        public DateTime NotificationMoment { get; set; }
        /// <summary>Percentage disablement</summary>
        public double PercentageDisablement { get; set; }
        /// <summary>Start date of absence</summary>
        public DateTime StartDate { get; set; }
        /// <summary>Start time on the first day of absence stored as DateTime, and the date should be ignored</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>Status of absence, 0 = Open, 1 = Recovered</summary>
        public Int16 Status { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Costcenter
    {
        /// <summary>Indicates if the cost center is active: 0 = inactive 1 = active</summary>
        public bool? Active { get; set; }
        /// <summary>Code (user-defined ID)</summary>
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
        /// <summary>Description (text)</summary>
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
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Costunit
    {
        /// <summary>Code (user-defined)</summary>
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
        /// <summary>Description (text)</summary>
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
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Department
    {
        /// <summary>Department Code</summary>
        public string Code { get; set; }
        /// <summary>Cost center Code</summary>
        public string Costcenter { get; set; }
        /// <summary>Cost center description</summary>
        public string CostcenterDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Department description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Explanation or extra information can be stored in the notes</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Division
    {
        /// <summary>Values: 0 = Not blocked 1 = Backup 2 = Conversion busy 3 = Conversion shadow 4 = Conversion waiting 5 = Copy data waiting 6 = Copy data buzy 100 = Wait for deletion 101 = Deleted 102 = Deletion failed</summary>
        public Int32? BlockingStatus { get; set; }
        /// <summary>First division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_01 { get; set; }
        /// <summary>Second division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_02 { get; set; }
        /// <summary>Third division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_03 { get; set; }
        /// <summary>Fourth division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_04 { get; set; }
        /// <summary>Fifth division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_05 { get; set; }
        /// <summary>Primary key</summary>
        public Int32 Code { get; set; }
        /// <summary>Country of the division. Is used for determination of legislation</summary>
        public string Country { get; set; }
        /// <summary>Description of Country</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Default currency of the division</summary>
        public string Currency { get; set; }
        /// <summary>Description of Currency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }
        /// <summary>Owner account of the division</summary>
        public Guid? Customer { get; set; }
        /// <summary>Owner account code of the division</summary>
        public string CustomerCode { get; set; }
        /// <summary>Owner account name of the division</summary>
        public string CustomerName { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Number that customers give to the division</summary>
        public Int64? HID { get; set; }
        /// <summary>True for the main (hosting) division</summary>
        public bool? Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Siret Number of the division (France)</summary>
        public string SiretNumber { get; set; }
        /// <summary>Date on which the division becomes active</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Regular administrations will have status 0.  Currently, the only other possibility is &apos;archived&apos; (1), which means the administration is not actively used, but still needs to be accessible for the customer/accountant to meet legal obligations</summary>
        public Int16? Status { get; set; }
        /// <summary>Number of your local tax authority (Germany)</summary>
        public string TaxOfficeNumber { get; set; }
        /// <summary>Local tax reference number (Germany)</summary>
        public string TaxReferenceNumber { get; set; }
        /// <summary>VAT number</summary>
        public string VATNumber { get; set; }
        /// <summary>Customer value, hyperlink to external website</summary>
        public string Website { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DivisionClass
    {
        /// <summary>Classification customer ID</summary>
        public Guid ClassNameCustomer { get; set; }
        /// <summary>Related classification description</summary>
        public string ClassNameDescription { get; set; }
        /// <summary>Related classification ID</summary>
        public Guid ClassNameID { get; set; }
        /// <summary>Property code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Property description</summary>
        public string Description { get; set; }
        /// <summary>Property description term ID</summary>
        public Int32? DescriptionTermID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Related classification sequence number </summary>
        public Int32 SequenceNr { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DivisionClassName
    {
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>ID of customer</summary>
        public Guid Customer { get; set; }
        /// <summary>Description of classification</summary>
        public string Description { get; set; }
        /// <summary>Term ID of the classification</summary>
        public Int32? DescriptionTermID { get; set; }
        /// <summary>Collection of classification properties</summary>
        public IEnumerable<HRM.DivisionClass> DivisionClasses { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Sequence number</summary>
        public Int32 SequenceNr { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DivisionClassValue
    {
        /// <summary>First classification</summary>
        public DivisionClass Class_01 { get; set; }
        /// <summary>First classification ID</summary>
        public Guid? Class_01_ID { get; set; }
        /// <summary>Second classification</summary>
        public DivisionClass Class_02 { get; set; }
        /// <summary>Second classification ID</summary>
        public Guid? Class_02_ID { get; set; }
        /// <summary>Third classification</summary>
        public DivisionClass Class_03 { get; set; }
        /// <summary>Third classification ID</summary>
        public Guid? Class_03_ID { get; set; }
        /// <summary>Fourth classification</summary>
        public DivisionClass Class_04 { get; set; }
        /// <summary>Fourth classification ID</summary>
        public Guid? Class_04_ID { get; set; }
        /// <summary>Fifth classification</summary>
        public DivisionClass Class_05 { get; set; }
        /// <summary>Fifth classification ID</summary>
        public Guid? Class_05_ID { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>ID of customer</summary>
        public Guid Customer { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class JobGroup
    {
        /// <summary>Job group code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Job group description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Explanation or extra information can be stored in the notes</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class JobTitle
    {
        /// <summary>Job title code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Job title description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference job code</summary>
        public string JobCode { get; set; }
        /// <summary>Group this job title belongs to</summary>
        public Guid? JobGroup { get; set; }
        /// <summary>Job group code</summary>
        public string JobGroupCode { get; set; }
        /// <summary>Job group description</summary>
        public string JobGroupDescription { get; set; }
        /// <summary>Job title represents job level from</summary>
        public Int32? JobLevelFrom { get; set; }
        /// <summary>Job title represents job level to</summary>
        public Int32? JobLevelTo { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Explanation or extra information can be stored in the notes</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class LeaveBuildUpRegistration
    {
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Date of leave build up</summary>
        public DateTime Date { get; set; }
        /// <summary>Description of leave build up</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the leave build up</summary>
        public Guid Employee { get; set; }
        /// <summary>Employee full name</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32 EmployeeHID { get; set; }
        /// <summary>Total number of leave build up hours</summary>
        public double Hours { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Type of leave</summary>
        public Guid LeaveType { get; set; }
        /// <summary>Code for type of leave</summary>
        public string LeaveTypeCode { get; set; }
        /// <summary>Description for type of leave</summary>
        public string LeaveTypeDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Extra information for leave build up</summary>
        public string Notes { get; set; }
        /// <summary>Status of leave build up, 1 = Submitted, 2 = Approved, 3 = Rejected</summary>
        public Int16 Status { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class LeaveRegistration
    {
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Description of leave</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the leave</summary>
        public Guid Employee { get; set; }
        /// <summary>Employee full name</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32 EmployeeHID { get; set; }
        /// <summary>End date of leave</summary>
        public DateTime EndDate { get; set; }
        /// <summary>End time on the last day of leave stored as DateTime, and the date should be ignored</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Total number of leave hours</summary>
        public double Hours { get; set; }
        /// <summary>Hours of leave on the first day</summary>
        public double? HoursFirstDay { get; set; }
        /// <summary>Hours of leave on the last day</summary>
        public double? HoursLastDay { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Type of leave</summary>
        public Guid LeaveType { get; set; }
        /// <summary>Code for type of leave</summary>
        public string LeaveTypeCode { get; set; }
        /// <summary>Description for type of leave</summary>
        public string LeaveTypeDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Extra information for leave</summary>
        public string Notes { get; set; }
        /// <summary>Start date of leave</summary>
        public DateTime StartDate { get; set; }
        /// <summary>Start time on the first day of leave stored as DateTime, and the date should be ignored</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>Status of leave, 1 = Submitted, 2 = Approved, 3 = Rejected</summary>
        public Int16 Status { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Schedule
    {
        /// <summary>Obsolete</summary>
        public byte? Active { get; set; }
        /// <summary>Average hours per week in a schedule</summary>
        public double? AverageHours { get; set; }
        /// <summary>Schedule code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Average days per week in the schedule</summary>
        public double? Days { get; set; }
        /// <summary>Description of the schedule</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employment ID for schedule</summary>
        public Guid? Employment { get; set; }
        /// <summary>Employment number</summary>
        public Int32? EmploymentHID { get; set; }
        /// <summary>End date of the schedule</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Number of hours per week in a CLA for which the schedule is built</summary>
        public double? Hours { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Number of hours which are built up each week for later leave</summary>
        public double? LeaveHoursCompensation { get; set; }
        /// <summary>Indication if the schedule is a main schedule for a CLA. 1 = Yes, 0 = No</summary>
        public byte? Main { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of the modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Part-time factor for payroll calculation. Value between 0 and 1</summary>
        public double? PaymentParttimeFactor { get; set; }
        /// <summary>Type of schedule. 1 = Hours and average days, 2 = Hours and specific days, 3 = Hours per day, 4 = Time frames per day</summary>
        public Int32? ScheduleType { get; set; }
        /// <summary>Description of the schedule type</summary>
        public string ScheduleTypeDescription { get; set; }
        /// <summary>Week in the schedule which is used to start with. By default the number will be 1.</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Week to start the schedule from for an employee</summary>
        public Int32? StartWeek { get; set; }
    }
}
