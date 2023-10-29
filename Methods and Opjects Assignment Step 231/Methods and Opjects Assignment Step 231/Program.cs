using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Opjects_Assignment_Step_231
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Sample", "Student", 12345);

            employee.sayName();

            Console.ReadLine();

        }
    }
}
