using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("This is the program that prints the maximal and minimal numbers from entered numbers, choose 'em! (Example: 1, 2, 3, 4, 5, 6, 7)");
        string userInput = Console.ReadLine();
        FindMinMax(userInput);
    }

    static void FindMinMax(string userInput)
    {
        string[] nums = userInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        if (nums.Length == 0)
        {
            throw new ArgumentException("Yo u, type the numbers in the correct format");
        }

        int[] intArray = nums.Select(int.Parse).ToArray();

        int maxNumber = intArray.Max();
        int minNumber = intArray.Min();

        Console.WriteLine("Max number is " + maxNumber);
        Console.WriteLine("Min number is " + minNumber);
    }
}
