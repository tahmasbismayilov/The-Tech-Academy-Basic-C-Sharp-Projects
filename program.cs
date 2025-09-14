using System;

class ShippingRateModule
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for item load
        Console.WriteLine("Please enter the package weight:");
        if (!double.TryParse(Console.ReadLine(), out double netLoad))
        {
            Console.WriteLine("Invalid format. Numbers only, please.");
            return;
        }

        // Weight cap validation
        if (netLoad > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Request first dimension
        Console.WriteLine("Please enter the package width:");
        if (!double.TryParse(Console.ReadLine(), out double axisX))
        {
            Console.WriteLine("Invalid format. Numbers only, please.");
            return;
        }

        // Request second dimension
        Console.WriteLine("Please enter the package height:");
        if (!double.TryParse(Console.ReadLine(), out double axisY))
        {
            Console.WriteLine("Invalid format. Numbers only, please.");
            return;
        }

        // Request third dimension
        Console.WriteLine("Please enter the package length:");
        if (!double.TryParse(Console.ReadLine(), out double axisZ))
        {
            Console.WriteLine("Invalid format. Numbers only, please.");
            return;
        }

        // Aggregate dimensions
        double sumOfSides = axisX + axisY + axisZ;

        // Dimensional limit check
        if (sumOfSides > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Compute estimate based on volume and load
        double estimateValue = (axisX * axisY * axisZ * netLoad) / 100;

        // Display final output
        Console.WriteLine("Your estimated total for shipping this package is: ${0:0.00}", estimateValue);
        Console.WriteLine("Thank you!");
    }
}
