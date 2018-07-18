using System;

namespace Payroll
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ActiveEmployment
    {
        /// <summary>The average number of contract days that an employee works per week</summary>
        public double? AverageDaysPerWeek { get; set; }
        /// <summary>The average number of contract hours that an employee works per week</summary>
        public double? AverageHoursPerWeek { get; set; }
        /// <summary>Employment contract ID</summary>
        public Guid? Contract { get; set; }
        /// <summary>Document ID of the employment contract</summary>
        public Guid? ContractDocument { get; set; }
        /// <summary>End date of employment contract</summary>
        public DateTime? ContractEndDate { get; set; }
        /// <summary>Employment probation end date</summary>
        public DateTime? ContractProbationEndDate { get; set; }
        /// <summary>Employment probation period</summary>
        public Int32? ContractProbationPeriod { get; set; }
        /// <summary>Start date of employment contract</summary>
        public DateTime? ContractStartDate { get; set; }
        /// <summary>Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External</summary>
        public Int32? ContractType { get; set; }
        /// <summary>Description of employment contract type</summary>
        public string ContractTypeDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Department of employee</summary>
        public Guid? Department { get; set; }
        /// <summary>Department code of employee</summary>
        public string DepartmentCode { get; set; }
        /// <summary>Description of department</summary>
        public string DepartmentDescription { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employee ID</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric number of Employee</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>Organization of employment</summary>
        public Guid? EmploymentOrganization { get; set; }
        /// <summary>End date of employment</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Numeric ID of the employment</summary>
        public Int32? HID { get; set; }
        /// <summary>Hourly wage</summary>
        public double? HourlyWage { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Internal rate for time &amp; billing or professional service user</summary>
        public double? InternalRate { get; set; }
        /// <summary>Job title of employee</summary>
        public Guid? Jobtitle { get; set; }
        /// <summary>Description of job title</summary>
        public string JobtitleDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>ID of employment ended</summary>
        public Int32? ReasonEnd { get; set; }
        /// <summary>Reason of end of employment</summary>
        public string ReasonEndDescription { get; set; }
        /// <summary>Reason of ended flexible employment</summary>
        public Int32? ReasonEndFlex { get; set; }
        /// <summary>Other reason for end of employment</summary>
        public string ReasonEndFlexDescription { get; set; }
        /// <summary>Employment salary</summary>
        public Guid? Salary { get; set; }
        /// <summary>Work schedule</summary>
        public Guid? Schedule { get; set; }
        /// <summary>Average hours per week in a schedule.</summary>
        public double? ScheduleAverageHours { get; set; }
        /// <summary>Work schedule code</summary>
        public string ScheduleCode { get; set; }
        /// <summary>Number of days of work per week</summary>
        public double? ScheduleDays { get; set; }
        /// <summary>Description of work schedule</summary>
        public string ScheduleDescription { get; set; }
        /// <summary>Number of work hours per week.</summary>
        public double? ScheduleHours { get; set; }
        /// <summary>Start date of employment</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Start date of the employee in the organization. This field is used to count the years in service.</summary>
        public DateTime? StartDateOrganization { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employee
    {
        /// <summary>Obsolete</summary>
        public byte? ActiveEmployment { get; set; }
        /// <summary>Second address line</summary>
        public string AddressLine2 { get; set; }
        /// <summary>Third address line</summary>
        public string AddressLine3 { get; set; }
        /// <summary>Street of address</summary>
        public string AddressStreet { get; set; }
        /// <summary>Street number of address</summary>
        public string AddressStreetNumber { get; set; }
        /// <summary>Street number suffix of address</summary>
        public string AddressStreetNumberSuffix { get; set; }
        /// <summary>Birth date</summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>Birth name</summary>
        public string BirthName { get; set; }
        /// <summary>Birth middle name</summary>
        public string BirthNamePrefix { get; set; }
        /// <summary>Birth place</summary>
        public string BirthPlace { get; set; }
        /// <summary>Email of the employee at the office</summary>
        public string BusinessEmail { get; set; }
        /// <summary>Fax number of the employee at the office</summary>
        public string BusinessFax { get; set; }
        /// <summary>Office mobile number of the employee</summary>
        public string BusinessMobile { get; set; }
        /// <summary>Phone number of the employee at the office</summary>
        public string BusinessPhone { get; set; }
        /// <summary>Phone extension of the employee at the office</summary>
        public string BusinessPhoneExtension { get; set; }
        /// <summary>Obsolete</summary>
        public string CASONumber { get; set; }
        /// <summary>City</summary>
        public string City { get; set; }
        /// <summary>Code of the employee</summary>
        public string Code { get; set; }
        /// <summary>Country code</summary>
        public string Country { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Customer ID</summary>
        public Guid? Customer { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Email address</summary>
        public string Email { get; set; }
        /// <summary>Employee number</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>End date of the employee</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>First name of the employee</summary>
        public string FirstName { get; set; }
        /// <summary>Full name of the employee</summary>
        public string FullName { get; set; }
        /// <summary>Gender</summary>
        public string Gender { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Initials</summary>
        public string Initials { get; set; }
        /// <summary>IsActive</summary>
        public bool IsActive { get; set; }
        /// <summary>Language code</summary>
        public string Language { get; set; }
        /// <summary>Last name</summary>
        public string LastName { get; set; }
        /// <summary>Description of the location of the employee (where am I?)</summary>
        public string LocationDescription { get; set; }
        /// <summary>Direct manager of the employee</summary>
        public Guid? Manager { get; set; }
        /// <summary>Date of marriage</summary>
        public DateTime? MaritalDate { get; set; }
        /// <summary>Marital status</summary>
        public Int16? MaritalStatus { get; set; }
        /// <summary>Middle name</summary>
        public string MiddleName { get; set; }
        /// <summary>Mobile phone</summary>
        public string Mobile { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Municipality</summary>
        public string Municipality { get; set; }
        public Int16? NameComposition { get; set; }
        /// <summary>Nationality</summary>
        public string Nationality { get; set; }
        /// <summary>Nick name</summary>
        public string NickName { get; set; }
        /// <summary>Additional notes</summary>
        public string Notes { get; set; }
        /// <summary>Name of partner</summary>
        public string PartnerName { get; set; }
        /// <summary>Middle name of partner</summary>
        public string PartnerNamePrefix { get; set; }
        /// <summary>Reference to the persons table in which the personal data of the employee is stored</summary>
        public Guid? Person { get; set; }
        /// <summary>Phone number</summary>
        public string Phone { get; set; }
        /// <summary>Phone number extension</summary>
        public string PhoneExtension { get; set; }
        /// <summary>Filename of picture</summary>
        public string PictureFileName { get; set; }
        /// <summary>Url of picture</summary>
        public string PictureUrl { get; set; }
        /// <summary>Postcode</summary>
        public string Postcode { get; set; }
        /// <summary>Private email address</summary>
        public string PrivateEmail { get; set; }
        /// <summary>Social security number</summary>
        public string SocialSecurityNumber { get; set; }
        /// <summary>Start date of the employee</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>State</summary>
        public string State { get; set; }
        /// <summary>Title</summary>
        public string Title { get; set; }
        /// <summary>User ID of employee</summary>
        public Guid? User { get; set; }
        /// <summary>Name of user</summary>
        public string UserFullName { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employment
    {
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employee ID</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric number of Employee</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>End date of employment</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Numeric ID of the employment</summary>
        public Int32? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>ID of employment ended</summary>
        public Int32? ReasonEnd { get; set; }
        /// <summary>Reason of end of employment</summary>
        public string ReasonEndDescription { get; set; }
        /// <summary>Reason of ended flexible employment</summary>
        public Int32? ReasonEndFlex { get; set; }
        /// <summary>Other reason for end of employment</summary>
        public string ReasonEndFlexDescription { get; set; }
        /// <summary>Start date of employment</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Start date of the employee in the organization. This field is used to count the years in service.</summary>
        public DateTime? StartDateOrganization { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContract
    {
        /// <summary>Flexible employment contract phase</summary>
        public Int32? ContractFlexPhase { get; set; }
        /// <summary>Flexible employment contract phase description.</summary>
        public string ContractFlexPhaseDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Document ID of the employment contract</summary>
        public Guid? Document { get; set; }
        /// <summary>ID of employee</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>Type of employee. 1 - Employee, 2 - Contractor, 3 - Temporary, 4 - Student, 5 - Flexworker</summary>
        public Int32? EmployeeType { get; set; }
        /// <summary>Employee type description</summary>
        public string EmployeeTypeDescription { get; set; }
        /// <summary>Employment ID</summary>
        public Guid? Employment { get; set; }
        /// <summary>Numeric ID of the employment</summary>
        public Int32? EmploymentHID { get; set; }
        /// <summary>End date of employment contract</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Notes of employment contract</summary>
        public string Notes { get; set; }
        /// <summary>Employment probation end date</summary>
        public DateTime? ProbationEndDate { get; set; }
        /// <summary>Employment probation period</summary>
        public Int32? ProbationPeriod { get; set; }
        /// <summary>Employment contract reason code. 1 - New employment, 2 - Employment change, 3 - New legal employer, 4 - Acquisition 5 - Previous contract expired, 6 - Other</summary>
        public Int32? ReasonContract { get; set; }
        /// <summary>Employment contract reason description</summary>
        public string ReasonContractDescription { get; set; }
        /// <summary>Sequence number</summary>
        public Int32? Sequence { get; set; }
        /// <summary>Start date of employment contract</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of employment contract type</summary>
        public string TypeDescription { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContractFlexPhas
    {
        /// <summary>Flexible employment contract phase description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Int32 ID { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentEndReason
    {
        /// <summary>Employment end reason description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Int32 ID { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentOrganization
    {
        /// <summary>Cost center code</summary>
        public string CostCenter { get; set; }
        /// <summary>Description of cost center</summary>
        public string CostCenterDescription { get; set; }
        /// <summary>Cost unit code</summary>
        public string CostUnit { get; set; }
        /// <summary>Description of cost unit</summary>
        public string CostUnitDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>ID of department</summary>
        public Guid? Department { get; set; }
        /// <summary>Department code</summary>
        public string DepartmentCode { get; set; }
        /// <summary>Department description for organization</summary>
        public string DepartmentDescription { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>ID of employee</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>Employement ID</summary>
        public Guid? Employment { get; set; }
        /// <summary>Numeric ID of the employment</summary>
        public Int32? EmploymentHID { get; set; }
        /// <summary>Organization end date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>ID of job title</summary>
        public Guid? JobTitle { get; set; }
        /// <summary>Job title code</summary>
        public string JobTitleCode { get; set; }
        /// <summary>Job title description</summary>
        public string JobTitleDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Explanation or extra information can be stored in the notes</summary>
        public string Notes { get; set; }
        /// <summary>Organization start date</summary>
        public DateTime? StartDate { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentSalary
    {
        /// <summary>The average number of contract days that an employee works per week</summary>
        public double? AverageDaysPerWeek { get; set; }
        /// <summary>The average number of contract hours that an employee works per week</summary>
        public double? AverageHoursPerWeek { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employee ID</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Employee number</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>Employment</summary>
        public Guid? Employment { get; set; }
        /// <summary>Employment number</summary>
        public Int32? EmploymentHID { get; set; }
        /// <summary>Salary type of employment. 1 - Periodical (fixed), 2 - Per hour (variable)</summary>
        public Int32? EmploymentSalaryType { get; set; }
        /// <summary>Salary type description</summary>
        public string EmploymentSalaryTypeDescription { get; set; }
        /// <summary>Salary record end date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Salary when working fulltime</summary>
        public double? FulltimeAmount { get; set; }
        /// <summary>Hourly wage</summary>
        public double? HourlyWage { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Internal rate for time &amp; billing or professional service user</summary>
        public double? InternalRate { get; set; }
        /// <summary>Employee job level in context of a wage scale</summary>
        public Int32? JobLevel { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Salary when working parttime</summary>
        public double? ParttimeAmount { get; set; }
        /// <summary>Contract hours / Fulltime contract hours</summary>
        public double? ParttimeFactor { get; set; }
        /// <summary>Employee wage scale</summary>
        public string Scale { get; set; }
        /// <summary>Employment schedule</summary>
        public Guid? Schedule { get; set; }
        /// <summary>Employment schedule code</summary>
        public string ScheduleCode { get; set; }
        /// <summary>Description of employment schedule</summary>
        public string ScheduleDescription { get; set; }
        /// <summary>Salary record start date</summary>
        public DateTime? StartDate { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxEmploymentEndFlexCode
    {
        /// <summary>Code of flexible employment contract phase</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Description of flexible employment contract phase</summary>
        public string Description { get; set; }
        /// <summary>End date of flexible employment contract</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Start date of flexible employment contract phase</summary>
        public DateTime? StartDate { get; set; }
    }
}
