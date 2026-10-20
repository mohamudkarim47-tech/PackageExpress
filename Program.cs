using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the required welcome message to the console
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package weight is greater than 50 pounds
            if (weight > 50)
            {
                // Display the error message and terminate the program if too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if the sum of the dimensions (width + height + length) is greater than 50
            if ((width + height + length) > 50)
            {
                // Display the error message and terminate the program if dimensions total too much
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Multiply the three dimensions and the weight together, then divide the outcome by 100
            double quote = (width * height * length * weight) / 100;

            // Display the quote to the user formatted as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            
            // Display closing message
            Console.WriteLine("Thank you!");
        }
    }
}