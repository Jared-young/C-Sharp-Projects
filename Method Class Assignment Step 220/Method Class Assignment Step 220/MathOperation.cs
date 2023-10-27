using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Step_220
{
    class MathOperation
    {
        static void Main()
        {
            int num1 = 25;
            int num2 = 27;

            MyVoid(num1, num2);
        }

        static void MyVoid(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum of {a} and {b} is: {sum}");
            Console.ReadLine();
        }
    }
}
