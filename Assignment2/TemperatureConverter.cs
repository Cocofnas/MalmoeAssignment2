namespace Assignment2
{
    public class TemperatureConverter
    {
        public void Start()
        {
            bool continueRun = true;
            while (continueRun)
            {
                DisplayMenu();
                int choice = ReadIntegerConsole("Enter your choice (0, 1, 2): ");

                switch (choice)
                {
                    case 1:
                        ConvertFahrenheitToCelsius();
                        break;
                    case 2:
                        ConvertCelsiusToFahrenheit();
                        break;
                    case 0:
                        continueRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 0, 1, or 2.");
                        break;
                }
            }
        }

        // Input method moved into the class and fixed 'result' initialization
        private int ReadIntegerConsole(string prompt)
        {
            int result = 0; // Initialize result to avoid CS0165 error
            bool valid = false;

            while (!valid)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                // Try to parse the input to an integer and validate the range (0, 1, or 2)
                if (int.TryParse(input, out result) && (result == 0 || result == 1 || result == 2))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 0, 1, or 2.");
                }
            }

            return result;
        }

        private void DisplayMenu()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("1. Convert Fahrenheit to Celsius. Temperatures from 0 to 212F.");
            Console.WriteLine("2. Convert Celsius to Fahrenheit. Temperatures from 0 to 100C.");
            Console.WriteLine("0. Exit converter and carry on to the next part.");
            Console.WriteLine("**************************************");
        }

        private void ConvertFahrenheitToCelsius()
        {
            for (int f = 0; f <= 212; f += 10)
            {
                double celsius = (5.0 / 9.0) * (f - 32);
                Console.WriteLine($"{f} Fahrenheit is {celsius:F2} Celsius");
            }
        }

        private void ConvertCelsiusToFahrenheit()
        {
            for (int c = 0; c <= 100; c += 5)
            {
                double fahrenheit = (9.0 / 5.0) * c + 32;
                Console.WriteLine($"{c} Celsius is {fahrenheit:F2} Fahrenheit");
            }
        }
    }
}
