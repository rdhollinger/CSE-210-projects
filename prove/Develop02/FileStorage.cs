
public class FileStorage
{
    // METHODS

    // Save
    /*public void SaveEntry(List<Entry> entries){
    string FileName = "journalEntries.txt";
    Console.WriteLine("Saving Entries...");
        using (StreamWriter outputFile = new StreamWriter(FileName, true)){
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.DateText},{entry.Prompt},{entry.Response}");
            }
        }
    }
     */   

    public void SaveEntry(List<Entry> entries){
    string FileName = "journalEntries.csv";
    Console.WriteLine("Saving Entries...");
        using (StreamWriter outputFile = new StreamWriter(FileName, true)){
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.DateText},{entry.Prompt},{entry.Response}");
            }
        }
    }
    // Load

    /*public List<Entry> LoadEntry(){
        string FileName = "journalEntries.txt";
        Console.WriteLine("Loading Entries...");
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(FileName);
        foreach (string line in lines){
            string[] parts = line.Split(",");
            string Date = parts[0];
            string Prompt = parts[1];
            string Response = parts[2];
            Entry entry = new Entry(Date, Prompt, Response);
            entries.Add(entry);
        }
        return entries;
    }
    */

    public List<Entry> LoadEntry(){
        string FileName = "journalEntries.csv";
        Console.WriteLine("Loading Entries...");
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(FileName);
        foreach (string line in lines){
            string[] parts = line.Split(",");
            string Date = parts[0];
            string Prompt = parts[1];
            string Response = parts[2];
            Entry entry = new Entry(Date, Prompt, Response);
            entries.Add(entry);
        }
        return entries;
    }
}