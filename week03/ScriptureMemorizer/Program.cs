using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        int i = 0;
        Random randomIndex = new Random();
        Scripture proverbs = new Scripture();
        Reference reference = new Reference();
        Word words = new Word();
        while (i == 0)
        {
            
            Console.Clear();
            proverbs.Display(reference._proverbs, words.words, words._isHidden);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                i= 1;
            }
            else if(!words._isHidden.Contains(false))
            {
                i = 1;
            }
            else
            {   
                int r = 0;
                while (r == 0)
                {
                    int index = randomIndex.Next(0,words.words.Length);
                    if (words._isHidden[index] == false) 
                    {
                        words.words[index] = words._blanks[index];
                        words._isHidden[index] = true;
                        r = 1;
                    } 
                }
                
            }
        }
        
    }
}