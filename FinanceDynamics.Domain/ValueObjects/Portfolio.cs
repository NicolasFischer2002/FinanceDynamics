using FinanceDynamics.Domain.Entities;

namespace FinanceDynamics.Domain.ValueObjects
{
    public class Portfolio
    {
        public Guid UserId { get; private set; }
        public Dictionary<Guid, Investment> Investments { get; private set; }

        internal Portfolio(Guid userId, Dictionary<Guid, Investment> investments)
        {
            UserId = userId;
            Investments = investments;
        }
    }
}