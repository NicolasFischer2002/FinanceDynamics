using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class NameAndDescriptionFactory : INameAndDescriptionFactory
    {
        private readonly INameAndDescriptionValidator _nameAndDescriptionValidator;

        public NameAndDescriptionFactory(INameAndDescriptionValidator nameAndDescriptionValidator)
        {
            _nameAndDescriptionValidator = nameAndDescriptionValidator;
        }

        public NameAndDescription Create(string name, string? description)
        {
            _nameAndDescriptionValidator.Validate(name, description);

            return new NameAndDescription(name, description);
        }
    }
}