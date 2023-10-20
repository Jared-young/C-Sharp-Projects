using System;

class Program
{
    static void Main()
    {
        // while statement
        Console.WriteLine("Using a 'while' statement to check if a number is less than or equal to the input value. Press enter to continue.");
        Console.ReadLine();
        Console.Write("Enter a number: ");
        int userNumber = int.Parse(Console.ReadLine());

        int number = 1;
        while (number <= userNumber)
        {
            Console.WriteLine($"Number is {number}, is it less than or equal to {userNumber}? {number <= userNumber}");
            number++;
        }

        // do-while
        Console.WriteLine("\nNow we will use a do-while statement to check if your number is less than or equal to 5. Press enter to continue.");
        Console.ReadLine();
        Console.Write("Enter a second number: ");
        int userNumber2 = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine($"Users second number is {userNumber2}, is it less than or equal to 5? {userNumber2 <= 5}");
            Console.ReadLine();
            userNumber2--;
        } while (userNumber2 >= 1);
    }
}


