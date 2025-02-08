using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Interfaces
{
    public interface ITransactionalMethodFactory
    {
        TransactionalMethod Create(NameAndDescription NameAndDescription);
    }
}