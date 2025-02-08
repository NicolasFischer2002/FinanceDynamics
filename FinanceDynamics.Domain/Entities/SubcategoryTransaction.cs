using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Domain.Entities
{
    public class SubcategoryTransaction : Subcategory
    {
        internal SubcategoryTransaction(NameAndDescription nameAndDescription) 
            : base(nameAndDescription)
        {

        }
    }
}