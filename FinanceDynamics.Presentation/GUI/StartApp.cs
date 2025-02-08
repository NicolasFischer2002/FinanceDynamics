using FinanceDynamics.Presentation.Interfaces;

namespace FinanceDynamics.Presentation.GUI
{
    internal class StartApp : IStartApp
    {
        private readonly IGraphicalUserInterface _graphicalUserInterface;

        public StartApp(IGraphicalUserInterface graphicalUserInterface)
        {
            _graphicalUserInterface = graphicalUserInterface;
        }

        public Task Run()
        {
            bool _continue = false;

            do
            {
                Console.WriteLine("Hello, World!");
            } while (_continue == true);

            return Task.CompletedTask;
        }
    }
}