using System;

class Program
{
    static void Main()
    {
        // Print header lines
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine();

        //Ask DR Questions and get responses from students
        Console.Write("What is your first and last name? ");
        string studentName = Console.ReadLine();

        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine();

        Console.Write("What page number within your course are you on? ");
        int pageNumber = int.Parse(Console.ReadLine());

        Console.Write("Do you need help with anything? Please answer 'true' or 'false': ");
        bool needsHelp = bool.Parse(Console.ReadLine());

        Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
        string positiveExperiences = Console.ReadLine();

        Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
        string otherFeedback = Console.ReadLine();

        Console.Write("How many hours did you study today? ");
        double studyHours = double.Parse(Console.ReadLine());

        // Thank you message
        Console.WriteLine();
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    }
}

