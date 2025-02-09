using FinanceDynamics.Presentation.Enums;

namespace FinanceDynamics.Presentation.Interfaces
{
    internal interface IStart
    {
        ActionTakenStart StartApplication();
        ActionTakenStart Login();
        ActionTakenStart CreateAccount();
    }
}