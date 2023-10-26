using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                int resultAdd = math.Add(userNumber);
                int resultSubtract = math.Subtract(userNumber);
                int resultMultiply = math.Multiply(userNumber);

                Console.WriteLine($"Result of adding 10: {resultAdd}");
                Console.WriteLine($"Result of subtracting 5: {resultSubtract}");
                Console.WriteLine($"Result of multiplying by 2: {resultMultiply}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.ReadLine();
        }
    }
}
