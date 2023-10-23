using System;

class Program
{
    static void Main()
    {
        
        string[] stringArray = new string[5];

        Console.WriteLine("Enter your favorite dish: ");
        string userInput = Console.ReadLine();

        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = "String " + (i + 1) + ": " + userInput;
   
        }

        Console.WriteLine("Modified Array Elements:");
        for (int i = 0; i < stringArray.Length; i++)
            
        {
            Console.WriteLine(stringArray[i]);
            Console.ReadLine();
        }
    }
}




