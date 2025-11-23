using FinanceDynamics.Domain.Enums;

namespace FinanceDynamics.Domain.Interfaces
{
    public interface ITransactionCategoryService
    {
        IEnumerable<string> GetCategories(TransactionType kind);
    }
}