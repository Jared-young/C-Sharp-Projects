using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Anonymous Income Comparison Program\n");

        //Person 1 Details
        Console.WriteLine("Person 1");
        int hourlyRate1 = GetHourlyRate("Hourly Rate");
        int hoursWorkedPerWeek1 = GetHoursWorked("Hours worked per week");
        int annualSalary1 = CalculateAnnualSalary(hourlyRate1, hoursWorkedPerWeek1);

        //Person 2 Details
        Console.WriteLine("\nPerson 2");
        int hourlyRate2 = GetHourlyRate("Hourly Rate");
        int hoursWorkedPerWeek2 = GetHoursWorked("Hours worked per week");
        int annualSalary2 = CalculateAnnualSalary(hourlyRate2, hoursWorkedPerWeek2);

        //Annual Salaries Listed
        Console.WriteLine($"\nAnnual salary of Person 1: {annualSalary1:C}");
        Console.ReadLine();
        Console.WriteLine($"Annual salary of Person 2: {annualSalary2:C}");
        Console.ReadLine();

        // Compare salaries
        bool person1EarnsMore = annualSalary1 > annualSalary2;
        Console.WriteLine($"\nDoes Person 1 make more money than Person 2? {person1EarnsMore}");
        Console.ReadLine();
    }
    int GetHourlyRate(string prompt)
    {
        Console.Write($"{prompt}: ");
        return GetInputFromUser();
    }
    int GetHoursWorked(string prompt)
    {
        Console.Write($"{prompt}: ");
        return GetInputFromUser();
    }
    int GetInputFromUser()
    {
        int input;
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return input;
    }
    int CalculateAnnualSalary(int hourlyRate, int hoursWorkedPerWeek)
    {
        return hourlyRate * hoursWorkedPerWeek * 52;
    }
}

