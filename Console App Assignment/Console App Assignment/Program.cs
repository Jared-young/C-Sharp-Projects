using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        string[] stringArray = new string[5];

        Console.WriteLine("Enter your top 5 favorite dish: ");
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
        //While loop section
        while (true)
         {
            Console.WriteLine("This is an infinite loop. Press q to exit.");
            string onInput = Console.ReadLine();
            //Used to leave infinate loop
            if (onInput.Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
         }

        //For Loop section
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine("Loop that interates until J = or >10");
            Console.ReadLine();
        }
        for (int k = 0; k <= 10; k++)
        {
            Console.WriteLine("Loop that interates until k >10");
            Console.ReadLine();
        }

        //List search section
        List<string> groceryList = new List<string>
        {"Soup", "Bananas", "Onions", "Chicken Breast", "Steak", "Spaghetti", "Tomatoes"};

        Console.WriteLine("Enter an item to see if its on the shopping list: ");
        string searchList = Console.ReadLine();
        bool matchFound = false;

        for( int k=0; k < groceryList.Count; k++)
        {
            if (groceryList[k].Equals(searchList, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Item on list {k}: {groceryList[k]}");
                matchFound = true;
                Console.ReadLine();
                break;
            }
        }

        if (!matchFound)
        {
            Console.WriteLine("Text not found in the list.");
            Console.ReadLine();
        }

        //foreach loop search section
        List<string> groceryList2 = new List<string>
        {"Soup", "Bananas", "Onions", "Chicken Breast", "Soup", "Spaghetti", "Onions"};

        foreach (string GL2 in groceryList2)
        {
            if(groceryList2.Contains(GL2))
            {
                Console.WriteLine($"item has already appeared in the list");
            }
            else
            {
                Console.WriteLine($"item '{GL2}' is a new entry in the list.");
                groceryList2.Add(GL2);
            }
        }
    }
}




