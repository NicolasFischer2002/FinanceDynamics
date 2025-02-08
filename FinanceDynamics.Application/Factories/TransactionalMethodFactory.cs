using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Domain.ValueObjects;

namespace FinanceDynamics.Application.Factories
{
    public class TransactionalMethodFactory : ITransactionalMethodFactory
    {
        public TransactionalMethod Create(NameAndDescription NameAndDescription)
        {
            return new TransactionalMethod(NameAndDescription);
        }
    }
}