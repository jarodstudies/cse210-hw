public class Journal
{

    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        
        foreach (Entry entry in _entries)
        {
            entry.Dipslay();
        }

    }

    public void SaveToFile(string file)
    {

        Console.WriteLine("Saving file .......\n");

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entries in _entries)
            {
                outputFile.WriteLine($"{entries._date},{entries._promptText},{entries._entryText}");  
            }
        }


    }

    public void LoadFromFile(string file)
    {

        Console.WriteLine("Reading File ......\n");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();
            newEntry._date =  parts[0];
            newEntry._promptText =  parts[1];
            newEntry._entryText =  parts[2];

            _entries.Add(newEntry);
            

        }


    }


}