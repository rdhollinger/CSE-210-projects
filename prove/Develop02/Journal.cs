using System;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private FileStorage io = new FileStorage();


    // METHODS

    // AddEntry
    public void AddEntry(){
        Entry entry = new Entry();
        entry.WriteEntry();
        entries.Add(entry);
    }

    // DisplayEntries
    public void DisplayEntry(){
        foreach(Entry entry in entries){
            entry.DisplayEntry();
        }

    }

    // SaveEntries
    public void SaveEntries(){
        io.SaveEntry(entries);
    }

    // LoadEntries 
    public void LoadEntries(){
        entries = io.LoadEntry();
    }
}