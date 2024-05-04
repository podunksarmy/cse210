using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
    }
}