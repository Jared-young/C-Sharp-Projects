using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Step_253
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
         
            return emp1.Id == emp2.Id;
        }


        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }
    }
}
