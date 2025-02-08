namespace FinanceDynamics.Domain.Entities
{
    /// <summary>
    /// Base class for entities requiring a unique identifier (Guid).
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets the unique identifier for the entity.
        /// </summary>
        public Guid Id { get; private set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}