using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        const int listlenght = 100;
        List<int> numbers = new List<int> (listlenght);
        Random random = new Random ();
        for (int i = 0; i < listlenght; i++)
        {
            numbers.Add(random.Next(-100,101));
            Console.Write(numbers[i] + " ");
        }
        try
        {
            int firstbig = numbers.First(x => x > 0);
            Console.WriteLine($"\nFirst positive number: {firstbig}");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("\nList doesnt contain positive number");
        }

        try
        {
            int lastsmall = numbers.Last(x => x < 0);
            Console.WriteLine($"Last negative number: {lastsmall}");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("List doesnt contain negative number");
        }
    }
}
