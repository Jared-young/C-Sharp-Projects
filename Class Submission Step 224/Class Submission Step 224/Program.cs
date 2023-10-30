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
            mathInstance.DivideByTwo(userInput, out int result);
            Console.WriteLine($"Result of division by 2 (using output parameter): {result}");

            
            Console.Write("Enter a number: ");
            int userInput2 = int.Parse(Console.ReadLine());
            StaticMethod.DivideByThree(userInput2, out int result2);
            Console.WriteLine($"Result of division by 3 (using output parameter): {result2}");
            Console.ReadLine();
        }
    }
}
