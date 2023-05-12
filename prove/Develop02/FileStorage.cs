
public class FileStorage
{
    // METHODS

    // Save
    public void SaveEntry(List<Entry> entries){
    string FileName = "journalEntries.txt";
        using (StreamWriter outputFile = new StreamWriter(FileName)){
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.DateText},{entry.Prompt},{entry.Response}");
            }
        }
    }
        
    // Load

    public List<Entry> LoadEntry(){
        string FileName = "journalEntries.txt";
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