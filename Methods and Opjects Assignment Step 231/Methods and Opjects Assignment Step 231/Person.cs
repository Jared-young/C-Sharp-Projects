using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Opjects_Assignment_Step_231
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void sayName()
        {
            string fullName = $"{FirstName} {LastName}";
            Console.WriteLine($"Name: { fullName}");
        }
    }
}
