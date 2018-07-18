using System;

namespace Mailbox
{
    using Newtonsoft.Json;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DefaultMailbox
    {
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Extra description of the mailbox</summary>
        public string Description { get; set; }
        /// <summary>Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration</summary>
        public Int32? ForDivision { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates whether this service is used for messages returned by the scanning service</summary>
        public bool IsScanServiceMailbox { get; set; }
        /// <summary>E-mail address-like format, for example johndoe@exactonline.nl</summary>
        public string Mailbox { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Date that this mailbox became valid</summary>
        public DateTime? ValidFrom { get; set; }
        /// <summary>Date that this mailbox will not be valid anymore</summary>
        public DateTime? ValidTo { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Mailbox
    {
        /// <summary>The account this mailbox belongs to. Can be empty if the owner of the mailbox isn&apos;t an Exact Online customer yet</summary>
        public Guid? Account { get; set; }
        /// <summary>Name of Account</summary>
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
        /// <summary>Extra description of the mailbox</summary>
        public string Description { get; set; }
        /// <summary>Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration</summary>
        public Int32? ForDivision { get; set; }
        /// <summary>Description of ForDivision</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ForDivisionDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>E-mail address-like format, for example johndoe@exactonline.nl</summary>
        [JsonProperty(PropertyName = "mailbox")]
        public string MailboxName { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Customers can decide if they want this mailbox to be visible by all. i.e. some other customer can see this in address maintenance for digital postbox of type Exact</summary>
        public byte Publish { get; set; }
        /// <summary>Type of mailbox. Exact / Government / Manual</summary>
        public Int16? Type { get; set; }
        /// <summary>Date that this mailbox became valid</summary>
        public DateTime? ValidFrom { get; set; }
        /// <summary>Date that this mailbox will not be valid anymore</summary>
        public DateTime? ValidTo { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessageAttachment
    {
        /// <summary>For performance reasons Attachment is Write-Only. The blob can be downloaded using the supplied Url</summary>
        public byte[] Attachment { get; set; }
        /// <summary>File extension of attachment</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AttachmentFileExtension { get; set; }
        /// <summary>File name of attachment</summary>
        public string AttachmentFileName { get; set; }
        /// <summary>File size</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int64 FileSize { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to Mail message</summary>
        public Guid MailMessageID { get; set; }
        /// <summary>Reference to recipient account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RecipientAccount { get; set; }
        /// <summary>Reference to sender account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SenderAccount { get; set; }
        /// <summary>Type of mail message attachment</summary>
        public Int32 Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
        /// <summary>To get the file in its original format (xml, jpg, pdf, etc.) append &lt;b&gt;&amp;Download=1&lt;/b&gt; to the url.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessagesReceived
    {
        /// <summary>Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
        public Guid? Bank { get; set; }
        /// <summary>Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
        public string BankAccount { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
        public Int32? ForDivision { get; set; }
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
        /// <summary>Specifies the operation upon dealing with the mailmessage (Kirean scan service)</summary>
        public Int16? Operation { get; set; }
        /// <summary>Provides a link to another MailMessage (Kirean scan service)</summary>
        public Guid? OriginalMessage { get; set; }
        /// <summary>Subject of the OriginalMessage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OriginalMessageSubject { get; set; }
        /// <summary>The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online</summary>
        public Guid? PartnerKey { get; set; }
        /// <summary>Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)</summary>
        public double? Quantity { get; set; }
        /// <summary>Reference to the account that is receiving this mailmessage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RecipientAccount { get; set; }
        /// <summary>Indiciates if the recipient deleted this message. If this is the case the recipient can&apos;t see it anymore and the sender can actually delete it</summary>
        public byte RecipientDeleted { get; set; }
        /// <summary>Mailbox of recipient</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientMailbox { get; set; }
        /// <summary>Mailbox description of recipient</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientMailboxDescription { get; set; }
        /// <summary>Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox</summary>
        public Guid? RecipientMailboxID { get; set; }
        /// <summary>Status of the mail message, only the recipient can update this</summary>
        public Int16? RecipientStatus { get; set; }
        /// <summary>Description of RecipientStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientStatusDescription { get; set; }
        /// <summary>Reference to Account of Sender</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SenderAccount { get; set; }
        /// <summary>Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)</summary>
        public DateTime? SenderDateSent { get; set; }
        /// <summary>Indicates if the sender deleted the message. This means the sender can&apos;t see it anymore and the recipient can actually delete it</summary>
        public byte SenderDeleted { get; set; }
        /// <summary>IP address of the sender</summary>
        public string SenderIPAddress { get; set; }
        /// <summary>Mailbox of sender</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SenderMailbox { get; set; }
        /// <summary>Description of SenderMailbox</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SenderMailboxDescription { get; set; }
        /// <summary>Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items</summary>
        public Guid? SenderMailboxID { get; set; }
        /// <summary>Subject of the mail message</summary>
        public string Subject { get; set; }
        /// <summary>Provides a link between Exact Online and the banks</summary>
        public string SynchronizationCode { get; set; }
        /// <summary>Type of the mail message</summary>
        public Int32? Type { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessagesSent
    {
        /// <summary>Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
        public Guid? Bank { get; set; }
        /// <summary>Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
        public string BankAccount { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.</summary>
        public Int32? ForDivision { get; set; }
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
        /// <summary>Specifies the operation upon dealing with the mailmessage (Kirean scan service)</summary>
        public Int16? Operation { get; set; }
        /// <summary>Provides a link to another MailMessage (Kirean scan service)</summary>
        public Guid? OriginalMessage { get; set; }
        /// <summary>Subject of the OriginalMessage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OriginalMessageSubject { get; set; }
        /// <summary>The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online</summary>
        public Guid? PartnerKey { get; set; }
        /// <summary>Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)</summary>
        public double? Quantity { get; set; }
        /// <summary>Reference to the account that is receiving this mailmessage</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? RecipientAccount { get; set; }
        /// <summary>Indiciates if the recipient deleted this message. If this is the case the recipient can&apos;t see it anymore and the sender can actually delete it</summary>
        public byte RecipientDeleted { get; set; }
        /// <summary>Mailbox of recipient</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientMailbox { get; set; }
        /// <summary>Mailbox description of recipient</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientMailboxDescription { get; set; }
        /// <summary>Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox</summary>
        public Guid? RecipientMailboxID { get; set; }
        /// <summary>Status of the mail message, only the recipient can update this</summary>
        public Int16? RecipientStatus { get; set; }
        /// <summary>Description of RecipientStatus</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string RecipientStatusDescription { get; set; }
        /// <summary>Reference to Account of Sender</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SenderAccount { get; set; }
        /// <summary>Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)</summary>
        public DateTime? SenderDateSent { get; set; }
        /// <summary>Indicates if the sender deleted the message. This means the sender can&apos;t see it anymore and the recipient can actually delete it</summary>
        public byte SenderDeleted { get; set; }
        /// <summary>IP address of the sender</summary>
        public string SenderIPAddress { get; set; }
        /// <summary>Mailbox of sender</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SenderMailbox { get; set; }
        /// <summary>Description of SenderMailbox</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SenderMailboxDescription { get; set; }
        /// <summary>Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items</summary>
        public Guid? SenderMailboxID { get; set; }
        /// <summary>Subject of the mail message</summary>
        public string Subject { get; set; }
        /// <summary>Provides a link between Exact Online and the banks</summary>
        public string SynchronizationCode { get; set; }
        /// <summary>Type of the mail message</summary>
        public Int32? Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PreferredMailbox
    {
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Extra description of the mailbox</summary>
        public string Description { get; set; }
        /// <summary>Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration</summary>
        public Int32? ForDivision { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates whether this service is used for messages returned by the scanning service</summary>
        public bool IsScanServiceMailbox { get; set; }
        /// <summary>E-mail address-like format, for example johndoe@exactonline.nl</summary>
        public string Mailbox { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Date that this mailbox became valid</summary>
        public DateTime? ValidFrom { get; set; }
        /// <summary>Date that this mailbox will not be valid anymore</summary>
        public DateTime? ValidTo { get; set; }
    }
}
