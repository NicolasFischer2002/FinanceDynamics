using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.Interfaces;

namespace FinanceDynamics.Application.Factories
{
    public class InstallmentFactory : IInstallmentFactory
    {
        private readonly IInstallmentValidator _installmentValidator;

        public InstallmentFactory(IInstallmentValidator installmentValidator)
        {
            _installmentValidator = installmentValidator;
        }

        public Installment Create(Guid transactionId, int number, decimal amount, DateTime dueDate, InstallmentStatus installmentStatus)
        {
            _installmentValidator.Validate(number, amount, dueDate);

            return new Installment(transactionId, number, amount, dueDate, installmentStatus);
        }
    }
}