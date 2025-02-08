using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface ITransactionCategoryFactory
    {
        TransactionCategory Create(NameAndDescription nameAndDescription, List<SubcategoryTransaction>? subcategories);
    }
}