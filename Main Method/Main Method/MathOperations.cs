using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MathOperations
{
    public int PerformMathOperation(int number, string operation)
    {
        int result = 0;

        switch (operation)
        {
            case "add":
                result = number + 10; 
                break;
            case "subtract":
                result = number - 5;
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }

        return result;
    }

    public int PerformMathOperation(decimal number, string operation)
    {
        int result = 0;

        switch (operation)
        {
            case "add":
                result = (int)(number + 10);
                break;
            case "subtract":
                result = (int)(number - 5);
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }

        return result;
    }

    public int PerformMathOperation(string number, string operation)
    {
        if (int.TryParse(number, out int parsedNumber))
        {
            return PerformMathOperation(parsedNumber, operation);
        }
        else
        {
            Console.WriteLine("Invalid input. Not a valid integer.");
            return 0;
        }
    }
}
