using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public abstract class Transaction<TCategory, TSubcategory>
        where TCategory : TransactionCategory
        where TSubcategory : SubcategoryTransaction<TCategory>?
    {
        public Guid Id { get; private set; }
        public Money Value { get; private set; }
        public TCategory Category { get; private set; }
        public TSubcategory? Subcategory { get; private set; }
        public TransactionMethod Method { get; private set; }
        public DateTime Date { get; private set; }
        public TransactionDescription? Description { get; private set; }
        public TransactionReceipt? Receipt { get; private set; }

        protected Transaction(
            Money value,
            TCategory category,
            TSubcategory? subcategory,
            TransactionMethod method,
            DateTime date,
            TransactionDescription? description = null,
            TransactionReceipt? receipt = null)
        {

            Id = Guid.NewGuid();
            Value = value;
            Category = category;
            Subcategory = subcategory;
            Method = method;
            Date = date;
            Description = description;
            Receipt = receipt;
        }

        protected Transaction(
            string id,
            Money value,
            TCategory category,
            TSubcategory? subcategory,
            TransactionMethod method,
            DateTime date,
            TransactionDescription? description = null,
            TransactionReceipt? receipt = null)
        {

            Id = Guid.Parse(id);
            Value = value;
            Category = category;
            Subcategory = subcategory;
            Method = method;
            Date = date;
            Description = description;
            Receipt = receipt;
        }
    }
}