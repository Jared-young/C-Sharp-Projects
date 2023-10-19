using System;

    class Program
    {
        static void Main()
        {
        Console.Write("How old are you?");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Have you ever had a DUI? (Answer with yes or no)");
        string dui = Console.ReadLine();
        bool yesDUI = dui == "yes";

        Console.Write("How many speeding tickets do you have?");
        int speedingTickets = int.Parse(Console.ReadLine());

        bool driverQualified = (age >= 16) && !yesDUI && (speedingTickets <= 3);

        Console.WriteLine("Qualified: " + driverQualified);
        Console.ReadLine();
    }
    }

