using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public abstract class Subcategory : BaseEntity
    {
        public NameAndDescription NameAndDescription { get; private set; }

        protected Subcategory(NameAndDescription nameAndDescription)
        {
            NameAndDescription = nameAndDescription;
        }
    }
}