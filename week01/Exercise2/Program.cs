using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("What is your grade percentage? ");
    string userGrade = Console.ReadLine();  
    int gradePercent = int.Parse(userGrade);

    string letter;
    if (gradePercent >= 90) 
    {   
        letter = "A";
    } 
    else if (gradePercent >= 80 && gradePercent < 90)
    {   
        letter = "B";
    }
    else if (gradePercent >= 70 && gradePercent < 80)
    {   
        letter = "C";
    }
    else if (gradePercent >= 60 && gradePercent < 70)
    {   
        letter = "D";
    }
    else
    {   
        letter = "F";       
    }
    Console.Write($"Your grade is {letter}.");
    if (gradePercent >= 70)
    {
        Console.Write("You Passed!");
    }
    else {
        Console.Write("You have not passed. Better luck next time!");
    }

    }
}