namespace Assignment2
{
    public class MathWork
    {
        public void Start()
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Calculate(); // Perform calculations for the given range

                continueRunning = ExitCalculation(); // Ask if they want to continue
            }
        }

        // Main method to calculate values for a given range
        private void Calculate()
        {
            Console.Write("Enter the starting number: ");
            string? startInput = Console.ReadLine();

            if (!int.TryParse(startInput, out int startNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the ending number: ");
            string? endInput = Console.ReadLine();

            if (!int.TryParse(endInput, out int endNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            // Call the methods for each task
            int sum = SumNumbers(startNumber, endNumber);
            Console.WriteLine($"Sum of numbers between {startNumber} and {endNumber}: {sum}");

            Console.WriteLine("Even numbers:");
            PrintEvenNumbers(startNumber, endNumber);

            Console.WriteLine("Odd numbers:");
            PrintOddNumbers(startNumber, endNumber);

            Console.WriteLine("Square roots:");
            CalculateSquareRoot(startNumber, endNumber);
        }

        // Method to calculate the sum of all numbers 
        private int SumNumbers(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        // Method to print even numbers 
        private void PrintEvenNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(); 
        }

        // Method to print odd numbers 
        private void PrintOddNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(); 
        }

        // Method to calculate the square root of numbers in the range with nested loops
        private void CalculateSquareRoot(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"Square roots starting from {i}: ");
                for (int j = i; j <= end; j++)
                {
                    Console.Write($"{Math.Sqrt(j):F2} ");
                }
                Console.WriteLine();
            }
        }

        // Method to ask if the user wants to continue or exit the program
        private bool ExitCalculation()
        {
            Console.Write("Exit Math Work? (y/n): ");
            string? answer = Console.ReadLine()?.ToLower();

            // If the user enters "y" or "yes", the program should exit (return false)
            // If the user enters "n" or "no", the program should continue (return true)
            return answer != "y" && answer != "yes";
        }

    }
}
