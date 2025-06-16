using FinanceDynamics.Domain.Enums;

namespace FinanceDynamics.Domain.Interfaces
{
    public interface ITransactionSubcategoryService
    {
        IEnumerable<string> GetSubcategories(TransactionKind kind, string categoryName);
    }
}