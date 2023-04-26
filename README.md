
public record CsvRow
{
    public string Key { get; init; }
    public string Value1 { get; init; }
    public string Value2 { get; init; }
}



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

class Program
{
    static void Main()
    {
        string csvFilePath = "path/to/your/csvfile.csv";

        Dictionary<string, Tuple<List<string>, List<string>>> myDictionary = new Dictionary<string, Tuple<List<string>, List<string>>>();

        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<CsvRow>();

            foreach (var record in records)
            {
                if (myDictionary.ContainsKey(record.Key))
                {
                    myDictionary[record.Key].Item1.Add(record.Value1);
                    myDictionary[record.Key].Item2.Add(record.Value2);
                }
                else
                {
                    myDictionary[record.Key] = Tuple.Create(
                        new List<string> { record.Value1 },
                        new List<string> { record.Value2 }
                    );
                }
            }
        }

        // Print the dictionary contents
        foreach (var entry in myDictionary)
        {
            Console.WriteLine($"Key: {entry.Key}");
            Console.WriteLine("List 1:");
            foreach (string item in entry.Value.Item1)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine("List 2:");
            foreach (string item in entry.Value.Item2)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
