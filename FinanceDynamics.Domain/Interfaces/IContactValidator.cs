namespace FinanceDynamics.Domain.Interfaces
{
    public interface IContactValidator
    {
        void ValidateEmail(string email);
        void ValidateTelephone(string telephone);
    }
}