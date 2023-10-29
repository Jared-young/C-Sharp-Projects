using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Step_224
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathInstance = new MathClass();

            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            mathInstance.DivideByTwo(userInput);

            mathInstance.DivideByTwo(userInput, out int result);
            Console.WriteLine($"Result of division by 2 (using output parameter): {result}");

            Console.ReadLine();
        }
    }
}
