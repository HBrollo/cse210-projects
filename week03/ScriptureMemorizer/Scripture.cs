public class Scripture
{
    public void Display(string reference,string[] words, bool[] blank)
    {
        Console.Write(reference);
        foreach (string word in words)
        {
            Console.Write($" {word}");
        }
    }
}