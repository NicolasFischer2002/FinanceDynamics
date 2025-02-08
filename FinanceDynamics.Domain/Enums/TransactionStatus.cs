namespace FinanceDynamics.Domain.Enums
{
    /// <summary>
    /// Enum que representa os status possíveis de uma transação.
    /// </summary>
    public enum TransactionStatus
    {
        /// <summary>
        /// A transação foi iniciada, mas ainda não foi concluída ou está aguardando algum tipo de ação.
        /// </summary>
        Pending,

        /// <summary>
        /// A transação foi finalizada com sucesso e a compra/venda foi concluída.
        /// </summary>
        Completed,

        /// <summary>
        /// A transação foi cancelada, não sendo mais válida.
        /// </summary>
        Cancelled,

        /// <summary>
        /// A transação está em andamento, sendo processada ou aguardando aprovação.
        /// </summary>
        InProgress,

        /// <summary>
        /// O pagamento da transação foi realizado, mas pode estar aguardando confirmação ou liquidação.
        /// </summary>
        Paid,

        /// <summary>
        /// O pagamento foi feito parcialmente, e o restante da transação ainda precisa ser quitado.
        /// </summary>
        PartiallyPaid,

        /// <summary>
        /// A transação está vencida, ou seja, o pagamento não foi realizado dentro do prazo.
        /// </summary>
        Overdue,

        /// <summary>
        /// A transação está sendo disputada, normalmente devido a uma contestação ou chargeback.
        /// </summary>
        Disputed
    }
}