using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Opjects_Assignment_Step_231
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public Employee(string firstName, string lastName, int id) : base(firstName, lastName)
        {
            Id = id;
        }
    }
}
