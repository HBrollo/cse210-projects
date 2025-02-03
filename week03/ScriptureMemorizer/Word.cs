public class Word
{

    public string[] words = { "Trust", "in", "the", "Lord", "with", "all", "thine", "heart", 
                   "and", "lean", "not", "unto", "thine", "own", "understanding.",
                   "In", "all", "thy", "ways,", "acknowledge", "him,", "and", 
                   "he", "shall", "direct", "thy", "paths." };


    public string[] _blanks = {"_____", "__", "___", "____", "____", "___", "_____", "_____", "___",
                    "____", "___", "____", "_____", "___", "_____________.", "__", "___", "___", "____,",
                    "___________", "___", "___", "__", "_____", "______", "___", "_____"};
    public bool[] _isHidden = 
    {
        false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false,
        false, false, false
        };

}