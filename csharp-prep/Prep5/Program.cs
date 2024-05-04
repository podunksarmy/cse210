using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();

       string userName = PromptUserName();
       int favoriteNumber = PromptUserNumber();

       int squaredNumber = SquareNumber(favoriteNumber);
    }

    static void DisplayWelcome()
       {
           Console.WriteLine("Welcome to the Program");
       }

    static PromptUserName(string userName)
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    static int PromptUserNumber(int userNumber)
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}")
    }
}
