using System;

class Program
{
    static void Main(string[] args)
    {
    //     string response = "yes";
    //     while (response == "yes")
    //     {       
    //         Console.WriteLine("What is the magic number?");
    //         string userNumber = Console.ReadLine();
    //         int magicNumber = int.Parse(userNumber);

    //         Console.Write("Guess a number: ");
    //         string userGuess = Console.ReadLine();
    //         int magicGuess = int.Parse(userGuess);

    //         if (magicGuess == magicNumber)
    //         {
    //             Console.WriteLine("Congratulations!  You guessed it!");
    //         }
    //         else if (magicGuess > magicNumber)
    //         {
    //             Console.WriteLine("Lower");
    //         }
    //         else if (magicGuess < magicNumber)
    //         {
    //             Console.WriteLine("Higher");
    //         }
    //         Console.Write("Do you want to continue? ");
    //         response = Console.ReadLine();
    //     }
    // 
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        int response = -1;

        
        while (response != magicNumber)
        {
            Console.WriteLine("Choose a number between 0 and 9999? ");
            response = int.Parse(Console.ReadLine());

            if (magicNumber < response)
            {
                Console.WriteLine("Too high! Guess again: ");
            }

            else if (magicNumber > response)
            {
                Console.WriteLine("Too low! Try again: ");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
    
        }
    }
}