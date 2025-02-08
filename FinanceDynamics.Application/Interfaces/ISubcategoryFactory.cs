using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Enums;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface ISubcategoryFactory
    {
        Subcategory Create(NameAndDescription nameAndDescription, TypeSubcategory type);
    }
}
