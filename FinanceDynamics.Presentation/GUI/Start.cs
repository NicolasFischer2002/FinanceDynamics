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
            bool _continue = true;

            do
            {
                int choice = _textGraphicalUserInterface
                .CreateMenu("Início", ["Login", "Criar conta", "Encerrar aplicação"]);

                switch (choice)
                {
                    case 1:
                        return Login();

                    case 2:
                        return CreateAccount();

                    case 3:
                        return ActionTakenStart.CloseApplication;

                    default:
                        return ActionTakenStart.CloseApplication;
                }

            } while (_continue);
        }

        public ActionTakenStart Login()
        {
            string? email = _textGraphicalUserInterface.FillInFormField("\nDigite seu e-mail: ", false);
            string? password = _textGraphicalUserInterface.FillInFormField("\nInforme sua senha: ", false);

            throw new NotImplementedException();
        }

        public ActionTakenStart CreateAccount()
        {
            throw new NotImplementedException();
        }
    }
}