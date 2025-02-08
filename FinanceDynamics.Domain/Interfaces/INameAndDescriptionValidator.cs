namespace FinanceDynamics.Domain.Interfaces
{
    /// <summary>
    /// Defines the contract for validating a name and its associated description.
    /// </summary>
    public interface INameAndDescriptionValidator
    {
        /// <summary>
        /// Validates both the name and the description according to predefined rules.
        /// </summary>
        /// <param name="name">The name to be validated.</param>
        /// <param name="description">The description to be validated.</param>
        void Validate(string name, string? description);

        /// <summary>
        /// Validates the name to ensure it is not null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="name">The name to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when the name is null, empty, or consists only of white-space characters.</exception>
        void ValidateName(string name);

        /// <summary>
        /// Validates the description to ensure it does not exceed the character limit and is not null or white-space.
        /// </summary>
        /// <param name="description">The description to be validated. It can be null.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the description exceeds the allowed character limit.</exception>
        void ValidateDescription(string? description);
    }
}