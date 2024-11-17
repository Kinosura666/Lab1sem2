using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        const int itemcount = 100000; 
        Random random = new Random();
        var defaultlist = new List<int>();
        for (int i = 0; i < itemcount; i++)
        {
            defaultlist.Add(random.Next(-100,101));
        }

        ////////////////////////////////////////////
        
        var linkedList = new LinkedList<int>();
        PerformanceDiff(linkedList, defaultlist, "LinkedList");

        var arrayList = new ArrayList();
        PerformanceDiff(arrayList, defaultlist, "ArrayList");

        var sortedSet = new SortedSet<int>();
        PerformanceDiff(sortedSet, defaultlist, "SortedSet");

        var hashSet = new HashSet<int>();
        PerformanceDiff(hashSet, defaultlist, "HashSet");

        ////////////////////////////////////////////
        
    }

    static void PerformanceDiff<T>(ICollection<T> collection, List<T> data, string collectionName)
    {
        // add

        var stopwatch = Stopwatch.StartNew();
        foreach (var item in data)
        {
            collection.Add(item);
        }
        stopwatch.Stop();
        Console.WriteLine($"{collectionName} - Add: {stopwatch.ElapsedMilliseconds} мс");

        // find

        stopwatch.Restart();
        foreach (var item in data)
        {
            collection.Contains(item);
        }
        stopwatch.Stop();
        Console.WriteLine($"{collectionName} - Find: {stopwatch.ElapsedMilliseconds} мс");

        // del

        stopwatch.Restart();
        foreach (var item in data)
        {
            collection.Remove(item);
        }
        stopwatch.Stop();
        Console.WriteLine($"{collectionName} - Remove: {stopwatch.ElapsedMilliseconds} мс\n");
    }

    static void PerformanceDiff(ArrayList collection, List<int> data, string collectionName)
    {
        // add

        var stopwatch = Stopwatch.StartNew();
        foreach (var item in data)
        {
            collection.Add(item);
        }
        stopwatch.Stop();
        Console.WriteLine($"{collectionName} - Add: {stopwatch.ElapsedMilliseconds} мс");

        // find

        stopwatch.Restart();
        foreach (var item in data)
        {
            collection.Contains(item);
        }
        stopwatch.Stop();
        Console.WriteLine($"{collectionName} - Find: {stopwatch.ElapsedMilliseconds} мс");

        // del

        stopwatch.Restart();
        foreach (var item in data)
        {
            collection.Remove(item);
        }
        stopwatch.Stop();
        Console.WriteLine($"{collectionName} - Remove: {stopwatch.ElapsedMilliseconds} мс\n");
    }
}
