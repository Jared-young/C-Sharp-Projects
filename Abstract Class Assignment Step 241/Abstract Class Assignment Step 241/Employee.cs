using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment_Step_241
{
    public class Employee : Person
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override void SayName()
        {
            string fullName = $"{FirstName} {LastName}";
            Console.WriteLine($"Name: {fullName}");
        }
    }
}
