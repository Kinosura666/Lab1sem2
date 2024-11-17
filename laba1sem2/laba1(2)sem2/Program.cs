using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        Dictionary<string, double> items = new Dictionary<string, double>
        {
            { "item1", 45.50 },
            { "item2", 35 },
            { "item3", 41.30 },
            { "item4", 55 },
            { "item5", 24 }
        };

        var top3 = items.OrderByDescending(x => x.Value).Take(3);
        Console.WriteLine("Top 3 biggest values:");
        foreach (var item in top3)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
        string jsonResult = JsonConvert.SerializeObject(top3.ToDictionary(x => x.Key, x => x.Value), Formatting.Indented);
        File.WriteAllText("result.json", jsonResult);
        Console.WriteLine("\nResult saved in result.json");
    }
}
