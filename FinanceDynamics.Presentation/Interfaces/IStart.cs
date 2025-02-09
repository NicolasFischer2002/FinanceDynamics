using FinanceDynamics.Presentation.Enums;

namespace FinanceDynamics.Presentation.Interfaces
{
    internal interface IStart
    {
        ActionTakenStart StartApplication();
        bool Login();
        bool CreateAccount();
    }
}