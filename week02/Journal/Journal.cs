using System.IO;
public class Journal
{
    public List<string> _entries = new List<string>();
    public void _displayEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
        
    }
    public string _filename;
    public void _saveEntries()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine();
        }
    }

    public void _loadEntries()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            _entries.Add(line);
        }
    }
};