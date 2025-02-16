using FinanceDynamics.Presentation.Interfaces;

namespace FinanceDynamics.Presentation.GUI
{
    internal class TextGraphicalUserInterface : ITextGraphicalUserInterface
    {
        private const string NavigationIcon = "➤";

        private void AddTitle(string title)
        {
            Console.WriteLine($"\n[ {title.ToUpper()} ]\n");
        }

        private void AddOption(int number, string option, bool isSelected)
        {
            if (isSelected)
                Console.WriteLine($"{NavigationIcon} {number} - {option}"); // Highlights the current option.
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

        public string FillInTheRequiredFieldOnTheForm(string message)
        {
            string? input;

            while (true)
            {
                Console.WriteLine(message);
                Console.Write($"{NavigationIcon} ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("❌ Este campo é obrigatório! Por favor, preencha corretamente.");
                    continue; // Repeat the loop until the field is filled correctly.
                }

                // If the field is valid (not mandatory or filled in correctly).
                break;
            }

            if (input is not null)
                return input;
            else
                throw new ArgumentNullException("", "O campo não pode ser nulo ou vazio.");
        }

        public string? FillInTheNonMandatoryFieldOfTheForm(string message)
        {
            Console.WriteLine(message);
            Console.Write($"{NavigationIcon} ");
            string? input = Console.ReadLine();

            return input;
        }

        /// <summary>
        /// Reads a confidential input from the user, displaying '*' instead of the actual characters.
        /// </summary>
        /// <param name="message">The message to display before the input prompt.</param>
        /// <returns>The user's input as a string.</returns>
        public string FillInTheConfidentialFieldOnTheForm(string message)
        {
            Console.WriteLine(message);
            Console.Write($"{NavigationIcon} ");

            string input = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(intercept: true); // Captures the key without displaying it in the terminal.

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(); // Moves to a new line when Enter is pressed.
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input = input[..^1]; // Removes the last character from the input string.
                    Console.Write("\b \b"); // Erases the last '*' from the console.
                }
                else if (!char.IsControl(key.KeyChar)) // Ignores control keys (Ctrl, Shift, etc.).
                {
                    input += key.KeyChar;
                    Console.Write("*"); // Displays '*' instead of the actual character.
                }
            } while (true);

            return input;
        }
    }
}