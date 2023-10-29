using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment_Step_241
{
    public class Employee : Person, IQuittable
    {
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
        }
        public void Quit()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} is quitting their job.");
            Console.ReadLine();
        }
    }
}
