public class Journal
{
    //attributes
    public List<Entry> _journal = new List<Entry>{};


    //behaviors    
    public void AddEntry(Entry e)
    {
        _journal.Add(e);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }
    }

    public override string ToString()
    {
        string journal = "";        
        foreach (Entry entry in _journal)
        {        
            string entryString = entry.ToString();
            string newJournal = journal + entryString;
            journal = newJournal;
            //note to self: ^^^ could also be written as 'journal += entry;' if trying to simplify            
        }
        return journal;
    }
}