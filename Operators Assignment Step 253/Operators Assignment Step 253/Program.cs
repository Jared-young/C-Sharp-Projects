using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Step_253
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Jared");
            Employee employee2 = new Employee(2, "Lauren");
            Employee employee3 = new Employee(1, "Jared");

            Console.WriteLine("employee1 == employee2: " + (employee1 == employee2)); 
            Console.WriteLine("employee1 == employee3: " + (employee1 == employee3));
            Console.WriteLine("employee2 == employee3: " + (employee2 == employee3));

            Console.ReadLine();
        }
    }
}
