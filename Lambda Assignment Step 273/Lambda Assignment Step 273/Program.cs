using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment_Step_273
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Jared", LastName = "Young" },
            new Employee { Id = 2, FirstName = "Jaime", LastName = "Smith" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Joeson" },
            new Employee { Id = 4, FirstName = "Lauren", LastName = "Kershberg" },
            new Employee { Id = 5, FirstName = "Joe", LastName = "Jonas" },
            new Employee { Id = 6, FirstName = "Jordan", LastName = "Kessel" },
            new Employee { Id = 7, FirstName = "Ahmed", LastName = "Sirage" },
            new Employee { Id = 8, FirstName = "David", LastName = "Schwimmer" },
            new Employee { Id = 9, FirstName = "Sam", LastName = "Gragg" },
            new Employee { Id = 10, FirstName = "Alex", LastName = "Schaffer" }
        };

            Console.WriteLine("Employees with the first name 'Joe' using a foreach loop:");
            List<Employee> joesWithForeach = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesWithForeach.Add(employee);
                }
            }
            foreach (var joe in joesWithForeach)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with the first name 'Joe' using a lambda expression:");
            List<Employee> joesWithLambda = employees.Where(e => e.FirstName == "Joe").ToList();
            foreach (var joe in joesWithLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with Id greater than 5 using a lambda expression:");
            List<Employee> employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();
            foreach (var employee in employeesWithIdGreaterThan5)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }
            Console.ReadLine();
        }
    }
}
