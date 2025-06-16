using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IIncomeFactory
    {
        Income Create(
            Money value,
            IncomeCategory category,
            IncomeSubcategory? subcategory,
            TransactionMethod method,
            DateTime date,
            TransactionDescription? description = null,
            TransactionReceipt? receipt = null
        );
    }
}