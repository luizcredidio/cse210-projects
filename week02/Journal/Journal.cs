using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

class Journal
{
    private List<Entry> entries = new List<Entry>();
    public void AddEntry(string date, string prompt, string entryText)
    {
        Entry newEntry = new Entry()
        {
            _dateText = date,
            _promptText = prompt,
            _entryText = entryText,
        };
        entries.Add(newEntry);
    }
    public void DisplayAllEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToFile(string fileName)
    {
        //https://learn.microsoft.com/en-us/dotnet/api/system.io.file.writealltext?view=net-8.0
        //https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer.serialize?view=net-8.0

        string serializedEntries = JsonSerializer.Serialize(entries, new JsonSerializerOptions { IncludeFields = true });

        File.WriteAllText(fileName, serializedEntries);
    }
    public void LoadFromFIle(string fileName)
    {
        string serializedEntries = File.ReadAllText(fileName);
        //https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer.deserialize?view=net-8.0#system-text-json-jsonserializer-deserialize(system-text-json-jsondocument-system-text-json-serialization-metadata-jsontypeinfo)
        entries = JsonSerializer.Deserialize<List<Entry>>(serializedEntries, new JsonSerializerOptions { IncludeFields = true });
    }

}