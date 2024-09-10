namespace Assignment2
{
    public class StringFunctions
    {
        public void Start()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                StringLength(); // Prompt the user to enter text and display the string length and uppercase version
                PredictMyDay(); // Predict the user's day based on input between 1 and 7

                continueRunning = RunAgain(); // Ask if the user wants to continue
            }
        }

        // Method to prompt the user to enter any text and display its length and uppercase version
        private void StringLength()
        {
            Console.Write("Enter some text: ");
            string? text = Console.ReadLine(); // Mark as nullable
            if (text == null)
            {
                Console.WriteLine("You didn't enter any text.");
                return;
            }

            int length = text.Length;

            // Display the length of the string and the text converted to uppercase
            Console.WriteLine($"Length of text: {length}");
            Console.WriteLine($"Uppercase: {text.ToUpper()}");
        }

        // Method to predict the user's day based on input between 1 and 7
        private void PredictMyDay()
        {
            int day = ReadIntegerConsole("Enter a number (1-7) to predict your day: ");

            string message = day switch
            {
                1 => "Keep calm on Mondays! You can fall apart!",
                2 => "Tuesdays and Wednesdays break your heart!",
                3 => "Tuesdays and Wednesdays break your heart!",
                4 => "Thursday is your lucky day, don't wait for Friday!",
                5 => "Friday, you are in love!",
                6 => "Saturday, do nothing and do plenty of it!",
                7 => "And Sunday always comes too soon!",
                _ => "Invalid day? This shouldn't happen!"
            };

            Console.WriteLine(message);
        }

        // Method to read an integer and ensure it's between 1 and 7
        private int ReadIntegerConsole(string prompt)
        {
            int result = 0; // Initialize result to avoid CS0165 error
            bool valid = false;

            while (!valid)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine(); // Mark as nullable

                // Check for null and valid integer range
                if (input != null && int.TryParse(input, out result) && result >= 1 && result <= 7)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                }
            }

            return result;
        }

        // Method to ask if the user wants to run the program again
        private bool RunAgain()
        {
            Console.Write("Would you like to run again? (y/n): ");
            string? answer = Console.ReadLine()?.ToLower(); // Mark as nullable
            return answer == "y" || answer == "yes";
        }
    }
}
