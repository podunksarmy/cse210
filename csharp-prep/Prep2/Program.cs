using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);

        if (userGrade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (userGrade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (userGrade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (userGrade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        int passFail = userGrade;

        if (passFail >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sucks to suck. Better luck next time!");
        }
    }   
}