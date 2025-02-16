using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IUserFactory
    {
        User Create(string name, Contact contact, Currency standardCurrency, Password password);
        User Create(string name, string  email, string telephone, string codeStandardCurrency, string password);
    }
}