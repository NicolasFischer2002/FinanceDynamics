using FinanceDynamics.Presentation.Interfaces;

namespace FinanceDynamics.Presentation.GUI
{
    internal class GraphicalUserInterface : IGraphicalUserInterface
    {
        public void InitializeGUI()
        {
            Console.Clear();
            SetDefaultAppearance();

            // This sets the console encoding to UTF-8, allowing Unicode characters
            // to be displayed correctly. It also makes symbols work and display
            // in the Console.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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