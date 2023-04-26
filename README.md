using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create the dictionary
        Dictionary<string, Tuple<List<string>, List<string>>> myDictionary = new Dictionary<string, Tuple<List<string>, List<string>>>();
        myDictionary["A"] = Tuple.Create(new List<string> { "TQ", "gh" }, new List<string> { "jh", "jk" });
        myDictionary["B"] = Tuple.Create(new List<string> { "vg", "bk" }, new List<string> { "nm", "vj" });
        myDictionary["C"] = Tuple.Create(new List<string> { "xy" }, new List<string> { "yz" });

        // Filter the dictionary based on a list of keys
        List<string> keys = new List<string> { "A", "B" };
        Dictionary<string, Tuple<List<string>, List<string>>> filteredDictionary = myDictionary
            .Where(entry => keys.Contains(entry.Key))
            .ToDictionary(entry => entry.Key, entry => entry.Value);

        // Print the filtered dictionary contents
        foreach (var entry in filteredDictionary)
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
