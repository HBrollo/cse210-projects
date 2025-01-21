using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
    string response = "yes";
    while (response == "yes") 
    {
        int mageNumber = randomGenerator.Next(1,100);
        int guess = 0;
        int tries = 0;
        while (guess != mageNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            tries++;
            if (guess == mageNumber) 
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {tries} tries.");
            }
            if (guess > mageNumber) 
            {
                Console.WriteLine("Lower");
            }
            if (guess < mageNumber) 
            {
                Console.WriteLine("Higher");
                
            }
        }
        Console.WriteLine("Would you like to keep playing?");
        response = Console.ReadLine();
    };
    }
}