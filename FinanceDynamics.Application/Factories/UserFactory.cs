using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.Interfaces;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class UserFactory : IUserFactory
    {
        private readonly IPersonValidator _personValidade;

        public UserFactory(IPersonValidator personValidade)
        {
            _personValidade = personValidade;
        }

        public User Create(string name, Contact contact, Currency standardCurrency, Password password)
        {
            _personValidade.ValidadeName(name);

            return new User(name, contact, standardCurrency, password, DateTime.Now);
        }
    }
}