using System;
using System.Collections.Generic;


namespace Parameter_Assignment_Step_256
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee<string>(new List<string> { "Laptop", "Backpack", "Phone" });

            var employee2 = new Employee<int>(new List<int> { 1, 2, 3, 4, 5 });

            Console.WriteLine("Employee 1's Things (strings):");
            foreach (var item in employee1.Things)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nEmployee 2's Things (integers):");
            foreach (var item in employee2.Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
