namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clear console and set title
            Console.Clear();
            Console.Title = "Assignment 2 <By: Alexandra Meija>";

            // Part 2A: Instantiate and start the TemperatureConverter object 
            TemperatureConverter converter = new TemperatureConverter();
            converter.Start();

            // Call to continue to the next part (StringFunctions)
            ContinueToNextPart("String Functions");

            // Part 2B: Instantiate and start the StringFunctions object 
            StringFunctions stringFunctions = new StringFunctions();
            stringFunctions.Start();

            // Call to continue to the next part (Math Work)
            ContinueToNextPart("The Math Work");

            // Part 2C: Instantiate and start the MathWork object 
            Console.WriteLine("Starting Math Work...");
            MathWork mathWork = new MathWork();
            mathWork.Start();

            // End of the assignment
            Console.WriteLine("You made it through all of the parts! Press enter to exit. Hope to see you soon!");
            Console.ReadLine();
        }

        // Helper method to move to the next part
        private static void ContinueToNextPart(string title)
        {
            Console.WriteLine("\nPress ENTER to continue to the next part...");
            Console.ReadLine(); // Wait for the user to press Enter
            Console.Clear(); // Clear the console
            Console.Title = title; // Set the console title for the next part
            Console.WriteLine("+++++++++++++++ " + title + " +++++++++++++++");
        }
    }
}
