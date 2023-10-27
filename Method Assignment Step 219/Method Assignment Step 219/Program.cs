using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment_Step_219
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (press Enter to not enter a second number.): ");
            string num2Input = Console.ReadLine();

            int num2;
            if (string.IsNullOrWhiteSpace(num2Input))
            {
                num2 = 0; //Sets second number to 0 if nothing is entered
               
            }
            else
            {
                num2 = int.Parse(num2Input);
                
            }
            if (num2 == 0)
            {
                int result = mathOperations.PerformMathOperation(num1);
                Console.WriteLine($"The result of the math operation is: {result}");
                Console.ReadLine();
            }
            else
            {
                int result = mathOperations.PerformMathOperation(num1, num2);
                Console.WriteLine($"The result of the math operation is: {result}");
                Console.ReadLine();
            }
            
        }
    }
}
