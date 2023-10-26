using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main()
        {
            MathOperations mathOps = new MathOperations();

            // Integer input
            int intResult = mathOps.PerformMathOperation(15, "add");
            Console.WriteLine("Result of addition: " + intResult);

            // Decimal input
            int decimalResult = mathOps.PerformMathOperation(8.5m, "subtract");
            Console.WriteLine("Result of subtraction: " + decimalResult);

            // String input 
            int stringResult = mathOps.PerformMathOperation("20", "multiply");
            Console.WriteLine("Result of multiplication: " + stringResult);

            Console.ReadLine(); 
        }
    }
}
