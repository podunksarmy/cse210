using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);
        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.Write(letter);
              
              
        int lastDigit = userGrade % 10;
   
        if (lastDigit > 7) 
        {
            Console.WriteLine("+");
        }
        else if (lastDigit < 3)
        {
            Console.WriteLine("-");
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