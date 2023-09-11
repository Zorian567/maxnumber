using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("This is the program that prints the maximal one from entered numbers, choose 'em! (Example: 1, 2, 3, 4, 5, 6, 7)");
        string userInput = Console.ReadLine();
        int maxNumber = Max(userInput);
        Console.WriteLine("Max number is " + maxNumber);
    }

    static int Max(string userInput)
    {
        string[] nums = userInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        if (nums.Length == 0)
        {
            throw new ArgumentException("No valid numbers found in the input.");
        }

        int[] intArray = nums.Select(int.Parse).ToArray();

        int maxone = intArray.Max();
        return maxone;
    }
}
