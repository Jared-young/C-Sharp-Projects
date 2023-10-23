using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] stringArray = { "Apple", "Banana", "Pineapple", "Orange", "Grape" };
        int[] intArray = { 100, 200, 300, 400, 500, 600 };
        List<string> stringList = new List<string> { "One", "Two", "Three", "Four", "Five", "Six", "Seven" };

        Console.WriteLine("Select a number form 0 to 4:");
        int stringIndex = GetUserIndex();
        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            Console.WriteLine("String at index " + stringIndex + ": " + stringArray[stringIndex]);
        }
        else
        {
            Console.WriteLine("You chose a number not between 0 and 4");
        }

        Console.WriteLine("\nSelect a number from 0 to 5:");
        int intIndex = GetUserIndex();
        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            Console.WriteLine("Integer at index " + intIndex + ": " + intArray[intIndex]);
        }
        else
        {
            Console.WriteLine("You chose a number not between 0 and 5");
        }

        Console.WriteLine("\nSelect a number from 0 to 6:");
        int listIndex = GetUserIndex();
        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            Console.WriteLine("Content at index " + listIndex + ": " + stringList[listIndex]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You chose a number not between 0 and 6");
            Console.ReadLine();
        }
    }

    static int GetUserIndex()
    {
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            return index;
        }
        return -1;
    }
}

