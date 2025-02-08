using FinanceDynamics.Presentation.Interfaces;

namespace FinanceDynamics.Presentation.GUI
{
    internal class GraphicalUserInterface : IGraphicalUserInterface
    {
        public void InitializeGUI()
        {
            Console.Clear();
            SetDefaultAppearance();
        }

        public void SetDefaultAppearance()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void SetErrorAppearance()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void SetSuccessAppearance()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void SetWarningAppearance()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}