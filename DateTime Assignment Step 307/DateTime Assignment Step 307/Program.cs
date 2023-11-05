using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment_Step_307
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time:" + currentDateTime);

            Console.Write("Enter a number of hours: ");
            if (int.TryParse(Console.ReadLine(), out int hoursToAdd))
            {
                DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);
                Console.WriteLine($"Time in {hoursToAdd} hours will be: {futureDateTime}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of hours.");
            }
            Console.ReadLine();
        }
    }
}
