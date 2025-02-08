namespace FinanceDynamics.Domain.ValueObjects
{
    public record Contact
    {
        public string Email { get; private set; }
        public string Telephone { get; private set; }

        internal Contact(string email, string telephone)
        {
            Email = email;
            Telephone = telephone;
        }
    }
}