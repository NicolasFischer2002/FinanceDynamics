using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class SubcategoryFactory : ISubcategoryFactory
    {
        public SubcategoryFactory()
        {
            
        }

        public Subcategory Create(NameAndDescription nameAndDescription, TypeSubcategory type)
        {
            return type switch
            {
                TypeSubcategory.SubcategoryTransaction => new SubcategoryTransaction(nameAndDescription),
                _ => throw new ArgumentException("Tipo de subcategoria inválido", nameof(type)),
            };
        }
    }
}