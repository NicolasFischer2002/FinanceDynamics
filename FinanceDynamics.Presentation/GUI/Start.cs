using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Entities;
using FinanceDynamics.Presentation.Enums;
using FinanceDynamics.Presentation.Interfaces;

namespace FinanceDynamics.Presentation.GUI
{
    internal class Start : IStart
    {
        private readonly IGraphicalUserInterface _graphicalUserInterface;
        private readonly ITextGraphicalUserInterface _textGraphicalUserInterface;
        private readonly IUserFactory _userFactory;

        public Start(IGraphicalUserInterface graphicalUserInterface, 
            ITextGraphicalUserInterface textGraphicalUserInterface,
            IUserFactory userFactory)
        {
            _graphicalUserInterface = graphicalUserInterface;
            _textGraphicalUserInterface = textGraphicalUserInterface;
            _userFactory = userFactory;
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
            string email = _textGraphicalUserInterface.FillInTheRequiredFieldOnTheForm("\nDigite seu e-mail: ");
            string password = _textGraphicalUserInterface.FillInTheRequiredFieldOnTheForm("\nInforme sua senha: ");

            return ActionTakenStart.LoginSuccessful;
        }

        public ActionTakenStart CreateAccount()
        {
            string name = _textGraphicalUserInterface.FillInTheRequiredFieldOnTheForm("\nDigite seu nome: ");
            string email = _textGraphicalUserInterface.FillInTheRequiredFieldOnTheForm("\nDigite seu e-mail: ");
            string telephone = _textGraphicalUserInterface
                .FillInTheRequiredFieldOnTheForm("\nDigite seu telefone: ");
            string codeStandardCurrency = 
                _textGraphicalUserInterface.FillInTheRequiredFieldOnTheForm
                ("\nDigite o código da moeda em que suas finanças devem ser calculadas: ");
            string? password = 
                _textGraphicalUserInterface.FillInTheConfidentialFieldOnTheForm("\nDigite sua senha: ");

            User user = _userFactory.Create(name, email, telephone, codeStandardCurrency, password);

            return ActionTakenStart.LoginSuccessful;
        }
    }
}