using System.Collections.Generic;
using System;

namespace Cashflow
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Bank
    {
        /// <summary>The name of the bank</summary>
        public string BankName { get; set; }
        /// <summary>The bank identification code of the bank</summary>
        public string BICCode { get; set; }
        /// <summary>The country in which the bank is based</summary>
        public string Country { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>The extended description of the bank</summary>
        public string Description { get; set; }
        /// <summary>The account format used by the bank</summary>
        public string Format { get; set; }
        /// <summary>The website of the bank</summary>
        public string HomePageAddress { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>The status of the bank. A = Active, P = Passive</summary>
        public string Status { get; set; }
    }

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DirectDebitMandate
    {
        /// <summary>Account to which the mandate belongs.</summary>
        public Guid? Account { get; set; }
        /// <summary>Bank account to which the mandate belongs.</summary>
        public Guid? BankAccount { get; set; }
        /// <summary>Date that the mandate is cancelled. Used to check the validity of the mandate.</summary>
        public DateTime? CancellationDate { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Displays the description of the mandate.</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Indicates the first collection hasn&apos;t been sent/confirmed with this mandate.</summary>
        public byte? FirstSend { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if the mandate is the main, you can have only one main mandate</summary>
        public byte? Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Depending on the payment type, a different bank file will be generated. 0 = One-off payment, 1 = Recurrent payment, 2 = AdHoc (UK only)</summary>
        public Int16? PaymentType { get; set; }
        /// <summary>Displays a reference number for the mandate. It is a unique reference number that you can assign to each mandate.</summary>
        public string Reference { get; set; }
        /// <summary>Date that the mandate is signed. The collection must take place after the signature date of the mandate. The date is used to check the validity of the mandate.</summary>
        public DateTime? SignatureDate { get; set; }
        /// <summary>Depending on the type, a different bank file will be generated. 0 = Core, 1 = B2B and 2 = bottomline (UK only)</summary>
        public Int16? Type { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Payment
    {
        /// <summary>The supplier to which the payment has to be done.</summary>
        public Guid? Account { get; set; }
        /// <summary>The bank account of the supplier, to which the payment has to be done.</summary>
        public Guid? AccountBankAccountID { get; set; }
        /// <summary>The bank account number of the supplier, to which the payment has to be done.</summary>
        public string AccountBankAccountNumber { get; set; }
        /// <summary>The code of the supplier to which the payment has to be done.</summary>
        public string AccountCode { get; set; }
        /// <summary>Contact person copied from the purchase invoice linked to the related purchase entry. Used as prefered contact when sending reminders.</summary>
        public Guid? AccountContact { get; set; }
        /// <summary>Name of the contact person of the supplier.</summary>
        public string AccountContactName { get; set; }
        /// <summary>Name of the supplier.</summary>
        public string AccountName { get; set; }
        /// <summary>The amount in default currency (division currency). Payments are matched on this amount.</summary>
        public double AmountDC { get; set; }
        /// <summary>The amount of the discount in the default currency.</summary>
        public double AmountDiscountDC { get; set; }
        /// <summary>The amount of the discount. This is in the amount of the selected currency.</summary>
        public double AmountDiscountFC { get; set; }
        /// <summary>The amount of the payment. This is in the amount of the selected currency.</summary>
        public double AmountFC { get; set; }
        /// <summary>Own bank account from which the payment must be done.</summary>
        public Guid? BankAccountID { get; set; }
        /// <summary>Own bank account number from which the payment must be done.</summary>
        public string BankAccountNumber { get; set; }
        /// <summary>When processing payments, all payments with the same processing data are put in a batch. This field contains the code of that batch.</summary>
        public string CashflowTransactionBatchCode { get; set; }
        /// <summary>Creation date.</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of the creator.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>The currency of the payment. This currency can only deviate from the division currency if the module Currency is in the license.</summary>
        public string Currency { get; set; }
        /// <summary>Extra description for the payment that may be included in the bank export file.</summary>
        public string Description { get; set; }
        /// <summary>Date before which the payment must be done to be eligible for discount.</summary>
        public DateTime? DiscountDueDate { get; set; }
        /// <summary>Division code.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document that is created when processing payments.  The bank export file is attached to the document.</summary>
        public Guid? Document { get; set; }
        /// <summary>Number of the document.</summary>
        public Int32? DocumentNumber { get; set; }
        /// <summary>Subject of the document.</summary>
        public string DocumentSubject { get; set; }
        /// <summary>Date before which the payment must be done.</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>Date since when the payment is no longer an outstanding item. This is the highest invoice date of all matched payments.</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Period since when the payment is no longer an outstanding item. This is the highest period of all matched payments.</summary>
        public Int16? EndPeriod { get; set; }
        /// <summary>Year (of period) since when the payment is no longer an outstanding item. This is the highest year of all matched payments. Used in combination with EndPeriod.</summary>
        public Int16? EndYear { get; set; }
        /// <summary>Processing date of the payment.</summary>
        public DateTime? EntryDate { get; set; }
        /// <summary>The unique identifier for a set of payments. A payment can be split so that one part is paid on a different date. In that case the two records get a different EntryID.</summary>
        public Guid? EntryID { get; set; }
        /// <summary>Entry number of the linked transaction.</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>G/L account of the payment. Must be of type 22 (Accounts payable).</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of the G/L account.</summary>
        public string GLAccountCode { get; set; }
        /// <summary>Description of the G/L account.</summary>
        public string GLAccountDescription { get; set; }
        /// <summary>Identifier of the payment.</summary>
        public Guid ID { get; set; }
        /// <summary>Invoice date of the linked transaction.</summary>
        public DateTime? InvoiceDate { get; set; }
        /// <summary>Invoice number of the linked transaction.</summary>
        public Int32? InvoiceNumber { get; set; }
        /// <summary>Boolean indicating whether the payment is part of a batch booking.</summary>
        public byte? IsBatchBooking { get; set; }
        /// <summary>Journal of the linked transaction.</summary>
        public string Journal { get; set; }
        /// <summary>Description of the journal.</summary>
        public string JournalDescription { get; set; }
        /// <summary>Last modified date.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Number assigned during the of processing payments. When payments are processed a bank export file is created. This file contains one or more batches that contain one or more payments. Each batch gets a sequence number that is stored for each payment in that batch.</summary>
        public Int32? PaymentBatchNumber { get; set; }
        /// <summary>Payment condition of the linked transaction.</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of the payment condition.</summary>
        public string PaymentConditionDescription { get; set; }
        /// <summary>Number of days between invoice date and due date.</summary>
        public Int32? PaymentDays { get; set; }
        /// <summary>Number of days between invoice date and due date of the discount.</summary>
        public Int32? PaymentDaysDiscount { get; set; }
        /// <summary>Payment discount percentage.</summary>
        public double? PaymentDiscountPercentage { get; set; }
        /// <summary>Method of payment.&lt;br&gt; B = On credit (default)&lt;br&gt; I = Collection&lt;br&gt; K = Cash&lt;br&gt; V = Credit card.</summary>
        public string PaymentMethod { get; set; }
        /// <summary>Payment reference for the payment that may be included in the bank export file.</summary>
        public string PaymentReference { get; set; }
        /// <summary>Date and time since when the payment is selected to be paid.</summary>
        public DateTime? PaymentSelected { get; set; }
        /// <summary>User who selected the payment to be paid.</summary>
        public Guid? PaymentSelector { get; set; }
        /// <summary>Name of the payment selector.</summary>
        public string PaymentSelectorFullName { get; set; }
        /// <summary>Exchange rate from payment currency to division currency. AmountFC * RateFC = AmountDC.</summary>
        public double? RateFC { get; set; }
        /// <summary>The source of the payment.&lt;br&gt; 1 = manual&lt;br&gt; 2 = reconcile&lt;br&gt; 3 = match&lt;br&gt; 4 = import&lt;br&gt; 5 = process</summary>
        public Int32 Source { get; set; }
        /// <summary>The status of the payment.&lt;br&gt; 20 = open&lt;br&gt; 30 = selected - payment is selected to be paid&lt;br&gt; 40 = processed - payment has been done&lt;br&gt; 50 = matched - payment is matched with one or more other outstanding items or financial statement lines</summary>
        public Int16? Status { get; set; }
        /// <summary>Total amount of the linked transaction in default currency (division currency).</summary>
        public double TransactionAmountDC { get; set; }
        /// <summary>Total amount of the linked transaction in the selected currency.</summary>
        public double TransactionAmountFC { get; set; }
        /// <summary>Due date of the linked transaction.</summary>
        public DateTime? TransactionDueDate { get; set; }
        /// <summary>Linked transaction. Use this as reference to PurchaseEntries.</summary>
        public Guid? TransactionEntryID { get; set; }
        /// <summary>Linked transaction line. Use this as reference to BankEntryLines and CashEntryLines.</summary>
        public Guid? TransactionID { get; set; }
        /// <summary>Indicates if the linked transaction is a reversal entry.</summary>
        public bool TransactionIsReversal { get; set; }
        /// <summary>Period of the linked transaction.</summary>
        public Int16? TransactionReportingPeriod { get; set; }
        /// <summary>Year of the linked transaction.</summary>
        public Int16? TransactionReportingYear { get; set; }
        /// <summary>Status of the linked transaction.</summary>
        public Int16? TransactionStatus { get; set; }
        /// <summary>Type of the linked transaction.</summary>
        public Int32? TransactionType { get; set; }
        /// <summary>Invoice number of the supplier. In case the payment belongs to a bank entry line and is matched with one invoice, YourRef is filled with the YourRef of this invoice.</summary>
        public string YourRef { get; set; }
    }

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class PaymentCondition
    {
        /// <summary>Code of the payment condition</summary>
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
        /// <summary>Default credit management scenario to be used for new payment terms</summary>
        public Guid? CreditManagementScenario { get; set; }
        /// <summary>Code of CreditManagementScenario</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioCode { get; set; }
        /// <summary>Description of CreditManagementScenario</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioDescription { get; set; }
        /// <summary>Description of the payment condition</summary>
        public string Description { get; set; }
        /// <summary>Indicates how the discount amount is calculated. Values: E = Excluding VAT, I = Including VAT</summary>
        public string DiscountCalculation { get; set; }
        /// <summary>Number of days to pay within, to have the right to take the discount</summary>
        public Int32? DiscountPaymentDays { get; set; }
        /// <summary>Discount percentage</summary>
        public double? DiscountPercentage { get; set; }
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
        /// <summary>Number of days to be included in the due date calculation. Example: invoice date = 17/01 PaymentEndOfMonths = 2 =&gt; 31/03 PaymentDays = 15 =&gt; 15/04</summary>
        public Int32? PaymentDays { get; set; }
        /// <summary>Type of payment discount. Values: B = Settlement discount, K = Credit surcharge</summary>
        public string PaymentDiscountType { get; set; }
        /// <summary>Number of month endings to be included in the due date calculation</summary>
        public Int32? PaymentEndOfMonths { get; set; }
        /// <summary>Method of payment. Values: B = On credit, I = Collection, K = Cash</summary>
        public string PaymentMethod { get; set; }
        /// <summary>Percentage (stored as fraction) of total invoice amount</summary>
        public double? Percentage { get; set; }
        /// <summary>Indicates how the VAT amount is calculated Values: E = Excluding discount, I = Including discount</summary>
        public string VATCalculation { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class PaymentID
    {
        /// <summary>ID of the payment to be processed.</summary>
        public Guid ID { get; set; }
    }

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class ProcessPayment
    {
        /// <summary>This is a URL to get the documents that were created after the payments were successfully processed. These documents have to be sent to the bank in order to do the payments.</summary>
        public string BankExportDocumentsUrl { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the processing of the payment(s).</summary>
        public string ErrorMessage { get; set; }
        /// <summary>Primary key.</summary>
        public Guid ID { get; set; }
        /// <summary>Use this field to pass a collection of GUIDs representing the IDs of the payments that have to be processed.</summary>
        public IEnumerable<Cashflow.PaymentID> PaymentIDs { get; set; }
        /// <summary>Contains information if the payments were successfully processed.</summary>
        public string SuccessMessage { get; set; }
    }

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Receivable
    {
        /// <summary>The customer from which the receivable will come.</summary>
        public Guid? Account { get; set; }
        /// <summary>The bank account of the customer, from which the receivable will come.</summary>
        public Guid? AccountBankAccountID { get; set; }
        /// <summary>The bank account number of the customer, from which the receivable will come.</summary>
        public string AccountBankAccountNumber { get; set; }
        /// <summary>The code of the customer from which the receivable will come.</summary>
        public string AccountCode { get; set; }
        /// <summary>Contact person copied from the purchase invoice linked to the related purchase entry.</summary>
        public Guid? AccountContact { get; set; }
        /// <summary>Name of the contact person of the customer.</summary>
        public string AccountContactName { get; set; }
        /// <summary>Name of the customer.</summary>
        public string AccountName { get; set; }
        /// <summary>The amount in default currency (division currency). Receivables are matched on this amount.</summary>
        public double AmountDC { get; set; }
        /// <summary>The amount of the discount in the default currency.</summary>
        public double AmountDiscountDC { get; set; }
        /// <summary>The amount of the discount. This is in the amount of the selected currency.</summary>
        public double AmountDiscountFC { get; set; }
        /// <summary>The amount of the receivable. This is in the amount of the selected currency.</summary>
        public double AmountFC { get; set; }
        /// <summary>Own bank account to which the receivable will be done.</summary>
        public Guid? BankAccountID { get; set; }
        /// <summary>Own bank account number to which the receivable will be done.</summary>
        public string BankAccountNumber { get; set; }
        /// <summary>When processing receivables, all receivable with the same processing data are put in a batch. This field contains the code of that batch.</summary>
        public string CashflowTransactionBatchCode { get; set; }
        /// <summary>Creation date.</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of the creator.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>The currency of the receivable. This currency can only deviate from the division currency if the module Currency is in the license.</summary>
        public string Currency { get; set; }
        /// <summary>Description.</summary>
        public string Description { get; set; }
        /// <summary>Direct Debit Mandate used to collect the receivable.</summary>
        public Guid? DirectDebitMandate { get; set; }
        /// <summary>Description of the mandate.</summary>
        public string DirectDebitMandateDescription { get; set; }
        /// <summary>Payment type of the mandate.&lt;br&gt; 0 = One off payment&lt;br&gt; 1 = Recurrent payment.</summary>
        public Int16? DirectDebitMandatePaymentType { get; set; }
        /// <summary>Unique mandate reference.</summary>
        public string DirectDebitMandateReference { get; set; }
        /// <summary>Type of the mandate.&lt;br&gt; 0 = Core&lt;br&gt; 1 = Business-to-business.</summary>
        public Int16? DirectDebitMandateType { get; set; }
        /// <summary>Date before which the payment by the customer must be done to be eligible for discount.</summary>
        public DateTime? DiscountDueDate { get; set; }
        /// <summary>Division code.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document that is created when processing collections.  The bank export file is attached to the document.</summary>
        public Guid? Document { get; set; }
        /// <summary>Number of the document.</summary>
        public Int32? DocumentNumber { get; set; }
        /// <summary>Subject of the document.</summary>
        public string DocumentSubject { get; set; }
        /// <summary>Date before which the payment by the customer must be done.</summary>
        public DateTime? DueDate { get; set; }
        /// <summary>Date since when the receivable is no longer an outstanding item. This is the highest invoice date of all matched receivables.</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Period since when the receivable is no longer an outstanding item. This is the highest period of all matched receivables.</summary>
        public Int16? EndPeriod { get; set; }
        /// <summary>The value of the tag &apos;EndToEndID&apos; when generating a SEPA file.</summary>
        public string EndToEndID { get; set; }
        /// <summary>Year (of period) since when the receivable is no longer an outstanding item. This is the highest year of all matched receivables. Used in combination with EndPeriod.</summary>
        public Int16? EndYear { get; set; }
        /// <summary>Processing date of the receivable.</summary>
        public DateTime? EntryDate { get; set; }
        /// <summary>The unique identifier for a set of receivables. A receivable can be split so that one part is received on a different date. In that case the two records get a different EntryID.</summary>
        public Guid? EntryID { get; set; }
        /// <summary>Entry number of the linked transaction.</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>G/L account of the payment. Must be of type 20 (Accounts receivable).</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of the G/L account.</summary>
        public string GLAccountCode { get; set; }
        /// <summary>Description of the G/L account.</summary>
        public string GLAccountDescription { get; set; }
        /// <summary>Identifier of the receivable.</summary>
        public Guid ID { get; set; }
        /// <summary>Invoice date of the linked transaction.</summary>
        public DateTime? InvoiceDate { get; set; }
        /// <summary>Invoice number of the linked transaction.</summary>
        public Int32? InvoiceNumber { get; set; }
        /// <summary>Boolean indicating whether the receivable is part of a batch booking.</summary>
        public byte? IsBatchBooking { get; set; }
        /// <summary>Boolean indicating whether the receivable was fully paid by the customer.</summary>
        public bool IsFullyPaid { get; set; }
        /// <summary>Journal of the linked transaction.</summary>
        public string Journal { get; set; }
        /// <summary>Description of the journal.</summary>
        public string JournalDescription { get; set; }
        /// <summary>Last payment date.</summary>
        public DateTime? LastPaymentDate { get; set; }
        /// <summary>Last modified date.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Payment condition of the linked transaction.</summary>
        public string PaymentCondition { get; set; }
        /// <summary>Description of the payment condition.</summary>
        public string PaymentConditionDescription { get; set; }
        /// <summary>Number of days between invoice date and due date.</summary>
        public Int32? PaymentDays { get; set; }
        /// <summary>Number of days between invoice date and due date of the discount.</summary>
        public Int32? PaymentDaysDiscount { get; set; }
        /// <summary>Payment discount percentage.</summary>
        public double? PaymentDiscountPercentage { get; set; }
        /// <summary>PaymentInformationID tag from the SEPA xml file.</summary>
        public string PaymentInformationID { get; set; }
        /// <summary>Method of payment.&lt;br&gt; B = On credit (default)&lt;br&gt; I = Collection&lt;br&gt; K = Cash&lt;br&gt; V = Credit card</summary>
        public string PaymentMethod { get; set; }
        /// <summary>Payment reference for the receivable that may be included In the bank export file</summary>
        public string PaymentReference { get; set; }
        /// <summary>Exchange rate from receivable currency to division currency. AmountFC * RateFC = AmountDC.</summary>
        public double? RateFC { get; set; }
        /// <summary>Number assigned during the processing of receivables.</summary>
        public Int32? ReceivableBatchNumber { get; set; }
        /// <summary>Date and time since when the receivable is selected to be collected.</summary>
        public DateTime? ReceivableSelected { get; set; }
        /// <summary>User who selected the receivable to be collected.</summary>
        public Guid? ReceivableSelector { get; set; }
        /// <summary>Name of the receivable selector.</summary>
        public string ReceivableSelectorFullName { get; set; }
        /// <summary>The source of the receivable.&lt;br&gt; 1 = manual&lt;br&gt; 2 = reconcile&lt;br&gt; 3 = match&lt;br&gt; 4 = import&lt;br&gt; 5 = process</summary>
        public Int32 Source { get; set; }
        /// <summary>The status of the receivable.&lt;br&gt; 20 = open&lt;br&gt; 30 = selected - receivable is selected to be collected&lt;br&gt; 40 = processed - collection has been done&lt;br&gt; 50 = matched - receivable is matched with one or more other outstanding items or financial statement lines</summary>
        public Int16? Status { get; set; }
        /// <summary>Total amount of the linked transaction in default currency (division currency).</summary>
        public double TransactionAmountDC { get; set; }
        /// <summary>Total amount of the linked transaction in the selected currency.</summary>
        public double TransactionAmountFC { get; set; }
        /// <summary>Due date of the linked transaction.</summary>
        public DateTime? TransactionDueDate { get; set; }
        /// <summary>Linked transaction. Use this as reference to SalesEntries.</summary>
        public Guid? TransactionEntryID { get; set; }
        /// <summary>Linked transaction line. Use this as reference to BankEntryLines and CashEntryLines.</summary>
        public Guid? TransactionID { get; set; }
        /// <summary>Indicates if the linked transaction is a reversal entry.</summary>
        public bool TransactionIsReversal { get; set; }
        /// <summary>Period of the linked transaction.</summary>
        public Int16? TransactionReportingPeriod { get; set; }
        /// <summary>Year of the linked transaction.</summary>
        public Int16? TransactionReportingYear { get; set; }
        /// <summary>Status of the linked transaction.</summary>
        public Int16? TransactionStatus { get; set; }
        /// <summary>Type of the linked transaction.</summary>
        public Int32? TransactionType { get; set; }
        /// <summary>Invoice number. In case the receivable belongs to a bank entry line and is matched with one invoice, YourRef is filled with the YourRef of this invoice.</summary>
        public string YourRef { get; set; }
    }
}
