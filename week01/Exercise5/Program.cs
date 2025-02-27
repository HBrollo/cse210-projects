using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult (name, square);
    }
    static void DisplayWelcome () 
    {
       Console.WriteLine("Welcome to the Program!");
    }     
    /*PromptUserName - Asks for and returns the user's name (as a string)*/
    static string PromptUserName() 
    {
       Console.Write("Please Enter Your Name:");
       string name = Console.ReadLine();
       return name;
    }
    /*PromptUserNumber - Asks for and returns the user's favorite number (as an integer)*/
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    /*SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)*/
    static int SquareNumber(int number) 
    {   
       int square = number * number; 
       return square;
    }
    /*DisplayResult - Accepts the user's name and the squared number and displays them.*/
    static void DisplayResult(string name, int square) 
    {
       Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}