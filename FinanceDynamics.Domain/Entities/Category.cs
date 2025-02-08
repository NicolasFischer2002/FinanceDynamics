using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public abstract class Category : BaseEntity
    {
        public NameAndDescription NameAndDescription { get; private set; }

        protected Category(NameAndDescription nameAndDescription)
        {
            NameAndDescription = nameAndDescription;
        }
    }
}