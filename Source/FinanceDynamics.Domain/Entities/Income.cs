using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class Income : Transaction
    {
        public Income(Money value, TransactionCategory category, TransactionMethod method, DateTime date, 
            TransactionDescription? description, TransactionReceipt? receipt) 
            : base(value, category, method, date, description, receipt)
        {

        }
    }
}