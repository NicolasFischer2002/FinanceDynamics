using FinanceDynamics.Presentation.Interfaces;

namespace FinanceDynamics.Presentation.GUI
{
    internal class StartApp : IStartApp
    {
        private readonly IGraphicalUserInterface _graphicalUserInterface;
        private readonly IStart _start;

        public StartApp(IGraphicalUserInterface graphicalUserInterface, IStart start)
        {
            _graphicalUserInterface = graphicalUserInterface;
            _start = start;
        }

        public Task Run()
        {
            bool _continue = false;

            do
            {
                var InitialReturn = _start.StartApplication();


            } while (_continue == true);

            return Task.CompletedTask;
        }
    }
}