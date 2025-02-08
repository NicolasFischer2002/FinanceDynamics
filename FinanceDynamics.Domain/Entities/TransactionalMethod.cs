using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class TransactionalMethod : BaseEntity
    {
        public NameAndDescription NameAndDescription { get; private set; }

        internal TransactionalMethod(NameAndDescription nameAndDescription)
        {
            NameAndDescription = nameAndDescription;
        }
    }
}