using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        Console.WriteLine("Press enter to begin");
        List<int> numbers = new List<int>();

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        Console.ReadLine();

        Console.WriteLine("Enter a number to divide each number in the list by:");

        try
        {
            int divisor = int.Parse(Console.ReadLine());

            Console.WriteLine("Results:");
            foreach (int number in numbers)
            {
                int result = number / divisor;
                Console.WriteLine($"{number} / {divisor} = {result}, Press enter for next result");
                Console.ReadLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number. Please enter a valid number.");
            Console.ReadLine();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
            Console.ReadLine();
        }

        Console.WriteLine("Program has emerged from the try/catch block and continued with execution.");
        Console.ReadLine();
    }
}

