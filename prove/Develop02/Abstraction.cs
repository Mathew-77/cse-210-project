1 Abstraction is the process object oriented programming where developer break and keep code in different componient in other to avoid complexity 
and enchance clearity for effienency and effetiveness and for easy maintaince of code in other to handle complexity by hiding the unnecessary detail 
from the end user

2. the benefit of Abstraction are 
1.for clearity and to reduce complexity
2. increase security 
3. increase reusability
4. avoid code duplication
5. easy couling

3. using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToCsv(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            // Write header row
            writer.WriteLine("Date,PromptText,EntryText");

            foreach (Entry entry in _entries)
            {
                // Write each entry in CSV format
                writer.WriteLine($"{entry.Date},{entry.PromptText},{entry.EntryText}");
            }
        }
    }

    public void LoadFromCsv(string file)
    {
        _entries.Clear(); // Clear existing entries before loading new ones

        using (StreamReader reader = new StreamReader(file))
        {
            // Skip header row
            reader.ReadLine();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
    }
}
6. Abstraction is the process where developer keep differient componient code in classes 
in other ti avoid complexity and to avoid duplication of code to creat effetiveness and effienency
by hiding the unnecessary detail from the public or end user abstration can be done in two form 
1. data abstraction is the process of dividing data into different entity while
2. process Abstraction is the functionality or the way and manner the prorammer wants to detail the process it could also be seen as the 
the hidden method developer wants a programm to return
the benefits are that it will reduce complexity of data and it will increase reusability of code, i will also increase security and avoid duplication of code
 