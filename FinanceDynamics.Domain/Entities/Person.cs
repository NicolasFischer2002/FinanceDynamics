namespace FinanceDynamics.Domain.Entities
{
    /// <summary>
    /// Represents a person with a unique identifier and a name.
    /// Inherits from <see cref="BaseEntity"/> to get the unique identifier.
    /// </summary>
    public abstract class Person : BaseEntity
    {
        public string Name { get; private set; }

        protected Person(string name)
        {
            Name = name;
        }
    }
}