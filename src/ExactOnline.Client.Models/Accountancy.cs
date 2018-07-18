using System;

namespace Accountancy
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class AccountInvolvedAccount
    {
        /// <summary>ID of account</summary>
        public Guid? Account { get; set; }
        /// <summary>Name of account</summary>
        public string AccountName { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>ID of involved account</summary>
        public Guid? InvolvedAccount { get; set; }
        /// <summary>Description of relation type</summary>
        public string InvolvedAccountRelationTypeDescription { get; set; }
        /// <summary>TermId of description of relation type</summary>
        public Int32? InvolvedAccountRelationTypeDescriptionTermId { get; set; }
        /// <summary>ID of relation type</summary>
        public Int16? InvolvedAccountRelationTypeId { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Use to record details of important information</summary>
        public string Notes { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class AccountOwner
    {
        /// <summary>ID of the account that is owned</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of the account that is owned</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of the account that is owned</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of the modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>ID of the account who owns specified account</summary>
        public Guid? OwnerAccount { get; set; }
        /// <summary>Code of the account who owns specified account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerAccountCode { get; set; }
        /// <summary>Name of the account who owns specified account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerAccountName { get; set; }
        /// <summary>Percentage of shares that is owned. 1 is 100%, 0.5 is 50%</summary>
        public double? Shares { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvolvedUser
    {
        /// <summary>ID of the account the user is involved with</summary>
        public Guid? Account { get; set; }
        /// <summary>City of the account</summary>
        public string AccountCity { get; set; }
        /// <summary>Code of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Supplier flag of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        /// <summary>Logo thumbnail url of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountLogoThumbnailUrl { get; set; }
        /// <summary>Name of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Status of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountStatus { get; set; }
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
        /// <summary>ID of the user role</summary>
        public Guid? InvolvedUserRole { get; set; }
        /// <summary>Description of the user role</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvolvedUserRoleDescription { get; set; }
        /// <summary>Main contact flag of the involved user</summary>
        public bool? IsMainContact { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Email of a person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonEmail { get; set; }
        /// <summary>Phone of a person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPhone { get; set; }
        /// <summary>Phone extension of a person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPhoneExtension { get; set; }
        /// <summary>Picture thumbnail url of a person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPictureThumbnailUrl { get; set; }
        /// <summary>ID of the involved user</summary>
        public Guid? User { get; set; }
        /// <summary>User name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UserFullName { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvolvedUserRole
    {
        /// <summary>Code of the involved user role</summary>
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
        /// <summary>Description of role</summary>
        public string Description { get; set; }
        /// <summary>Description term code of role</summary>
        public Int32? DescriptionTermID { get; set; }
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
    public class SolutionLink
    {
        /// <summary>ID of account to which solution is linked</summary>
        public Guid Account { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Accountant main division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>If type is external predefined, represents ID of PracticeManagementExternalSolutions (mandatory for External solution)</summary>
        public Int32? ExternalSolutionCode { get; set; }
        /// <summary>Name of the external solution</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalSolutionName { get; set; }
        /// <summary>Customer URl in external solution, like solution.com/id123 (mandatory for External and ExternalOther solution)</summary>
        public string ExternalSolutionUrl { get; set; }
        /// <summary>Primary key</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        /// <summary>Division code of linked internal solution (mandatory for Internal solution)</summary>
        public Int32? InternalSolutionDivision { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the solution link</summary>
        public string Name { get; set; }
        /// <summary>Name of the custom external solution (mandatory for ExternalOther solution)</summary>
        public string OtherExternalSolutionName { get; set; }
        /// <summary>Type of solution: 0 - Internal(EOL), 1 - External(Wellknown solution), 2 - ExternalOther</summary>
        public Int32 SolutionType { get; set; }
        /// <summary>Link status: 0 - Active, 1 - Inactive, 2 -Archived</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Status { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TaskType
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Name of the task type</summary>
        public string Description { get; set; }
        /// <summary>Term ID of the task type</summary>
        public Int32? DescriptionTermID { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of the modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
    }
}
