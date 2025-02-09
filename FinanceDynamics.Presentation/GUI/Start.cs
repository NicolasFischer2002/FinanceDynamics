using FinanceDynamics.Presentation.Enums;
using FinanceDynamics.Presentation.Interfaces;

namespace FinanceDynamics.Presentation.GUI
{
    internal class Start : IStart
    {
        private readonly IGraphicalUserInterface _graphicalUserInterface;
        private readonly ITextGraphicalUserInterface _textGraphicalUserInterface;

        public Start(IGraphicalUserInterface graphicalUserInterface, 
            ITextGraphicalUserInterface textGraphicalUserInterface)
        {
            _graphicalUserInterface = graphicalUserInterface;
            _textGraphicalUserInterface = textGraphicalUserInterface;
        }

        ActionTakenStart IStart.StartApplication()
        {
            int choice  = _textGraphicalUserInterface
                .CreateMenu("Início", ["Login", "Criar conta", "Encerrar aplicação"]);

            return choice switch
            {
                1 => ActionTakenStart.LoginSuccessful,
                2 => ActionTakenStart.LoginFailed,
                3 => ActionTakenStart.CloseApplication,
                _ => ActionTakenStart.CloseApplication
            };
        }

        public bool CreateAccount()
        {
            throw new NotImplementedException();
        }

        public bool Login()
        {
            throw new NotImplementedException();
        }
    }
}
