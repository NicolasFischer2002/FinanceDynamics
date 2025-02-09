using FinanceDynamics.Presentation.Interfaces;

namespace FinanceDynamics.Presentation.GUI
{
    internal class TextGraphicalUserInterface : ITextGraphicalUserInterface
    {
        private void AddTitle(string title)
        {
            Console.WriteLine($"\n[ {title.ToUpper()} ]\n");
        }

        private void AddOption(int number, string option, bool isSelected)
        {
            if (isSelected)
                Console.WriteLine($"➤ {number} - {option}"); // Highlights the current option.
            else
                Console.WriteLine($"  {number} - {option}"); // Normal option.
        }

        public int CreateMenu(string title, IReadOnlyList<string> options)
        {
            if (options == null || options.Count == 0)
                throw new ArgumentException("A lista de opções não pode estar vazia.");

            int selectedIndex = 0; // Always start with the first option.

            while (true)
            {
                Console.Clear(); // Clear the screen to redraw the menu.
                AddTitle(title);

                // Renders menu options.
                for (int i = 0; i < options.Count; i++)
                {
                    AddOption(i + 1, options[i], i == selectedIndex);
                }

                Console.WriteLine("\nUse as setas ↑ ↓ para navegar e ENTER para selecionar...");

                // Capture the pressed key.
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedIndex > 0)
                            selectedIndex--; // Move up.
                        else
                            selectedIndex = options.Count - 1; // Return to the last option (looping effect).
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedIndex < options.Count - 1)
                            selectedIndex++; // Move down.
                        else
                            selectedIndex = 0; // Return to the first option (looping effect).
                        break;
                    case ConsoleKey.Enter:
                        return selectedIndex + 1; // Returns the chosen option (base 1).
                }
            }
        }
    }
}