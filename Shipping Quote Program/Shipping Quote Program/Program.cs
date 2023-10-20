using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below to get a quote on shipping costs for your package.");

        Console.Write("Enter the package weight (in pounds): ");
        decimal weight = decimal.Parse(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        }
        else
        {
            Console.Write("Enter the package width (in inches): ");
            decimal width = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the package height (in inches): ");
            decimal height = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the package length (in inches): ");
            decimal length = decimal.Parse(Console.ReadLine());

            decimal dimensionsTotal = width + height + length;

            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                decimal quote = (width * height * length * weight) / 100;
                Console.WriteLine($"Your shipping quote is: {quote:C}");
                Console.ReadLine();
            }
        }
    }
}

