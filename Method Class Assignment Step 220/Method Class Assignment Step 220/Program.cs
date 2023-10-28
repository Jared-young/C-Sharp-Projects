using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Step_220
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();

            
            mathOperation.PerformMathOperation(5, 7);
            Console.WriteLine("Press enter to see next operation");
            Console.ReadLine();

            mathOperation.PerformMathOperation(num1: 10, num2: 20);

            Console.ReadLine();
        }
        
    }
}
