using System.ComponentModel;

namespace FinanceDynamics.Domain.Enums
{
    public enum TransactionMethod
    {
        [Description("Cartão de crédito")]
        CreditCard = 0,

        [Description("Cartão de débito")]
        DebitCard,

        [Description("Depósito")]
        Deposit,

        [Description("Dinheiro")]
        Money,

        [Description("PIX")]
        PIX,

        [Description("Boleto")]
        Boleto,
    }
}