using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface IContactFactory
    {
        Contact Create(string email, string telephone);
    }
}
