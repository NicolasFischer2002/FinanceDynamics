using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface INameAndDescriptionFactory
    {
        NameAndDescription Create(string name, string? description);
    }
}