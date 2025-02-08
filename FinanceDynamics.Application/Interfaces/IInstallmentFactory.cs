using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IInstallmentFactory
    {
        Installment Create(Guid transactionId, int number, decimal amount, DateTime dueDate, InstallmentStatus installmentStatus);
    }
}