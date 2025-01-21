using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    int finished = 1;
    List<int> numbers = new List<int>();
    while (finished != 0) 
    {
        Console.Write("Enter Number:");
        int input = int.Parse(Console.ReadLine());
        if (input != 0) 
        {
            numbers.Add(input);
        }
        else 
        {
            finished = input;
        }
    }
    int start = 0;
    int sum = 0;
    int largestNumber = 0;
    foreach (int item in numbers)
    {
        sum = start + item;
        start = sum;
        if (item > largestNumber)
        {
            largestNumber = item;
        }
    }
    float average = ((float)sum) / numbers.Count;

    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"The largest number is: {largestNumber}");

    }
}