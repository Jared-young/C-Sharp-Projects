using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment_Step_262
{
    public enum DayOfWeekEnum
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the current day of the week: ");
                string input = Console.ReadLine();

                DayOfWeekEnum currentDay;
                if (Enum.TryParse(input, true, out currentDay))
                {
                    Console.WriteLine($"You entered: {currentDay}");
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception example)
            {
                Console.WriteLine("An Error Occured: " + example.Message);
            }
            Console.ReadLine();
        }
    }
}
