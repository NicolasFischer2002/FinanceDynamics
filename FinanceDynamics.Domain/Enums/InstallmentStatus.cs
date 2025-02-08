namespace FinanceDynamics.Domain.Enums
{
    /// <summary>
    /// Represents the status of an installment in a transaction.
    /// </summary>
    public enum InstallmentStatus
    {
        /// <summary>
        /// The installment is pending and has not been paid yet.
        /// </summary>
        Pending,

        /// <summary>
        /// The installment has been paid in full.
        /// </summary>
        Paid,

        /// <summary>
        /// The installment is overdue and has not been paid by the due date.
        /// </summary>
        Overdue,

        /// <summary>
        /// The installment was canceled and is no longer valid.
        /// </summary>
        Canceled
    }
}