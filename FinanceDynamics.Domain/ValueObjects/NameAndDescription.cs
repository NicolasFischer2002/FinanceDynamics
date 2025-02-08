namespace FinanceDynamics.Domain.ValueObjects
{
    public class NameAndDescription
    {
        public string Name { get; private set; }
        public string? Description { get; private set; }

        internal NameAndDescription(string name, string? description)
        {
            Name = name;
            Description = description;
        }
    }
}