using FinanceDynamics.Domain.ValueObjects;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Application.Interfaces;

namespace FinanceDynamics.Application.Factories
{
    public class PasswordFactory : IPasswordFactory
    {
        private readonly IPasswordValidator _passwordValidator;

        public PasswordFactory(IPasswordValidator passwordValidator)
        {
            _passwordValidator = passwordValidator;
        }

        public Password Create(string value)
        {
            _passwordValidator.Validate(value);

            return new Password(value);
        }
    }
}