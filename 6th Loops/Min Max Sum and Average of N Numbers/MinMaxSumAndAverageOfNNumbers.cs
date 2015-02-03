using System;
using System.Linq;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double average = 0;

        Console.WriteLine("Enter the {0} numbers:", n);

        int[] entry = new int[n];
        for (int i = 0; i < n; i++)
        {
            entry[i] = int.Parse(Console.ReadLine());
        }
        foreach (var x in entry)
        {
            sum += x;
        }
        average = sum / entry.Length;

        Console.WriteLine("Min={0}", entry.Min());
        Console.WriteLine("Max={0}", entry.Max());
        Console.WriteLine("Sum={0}", sum);
        Console.WriteLine("Avg={0:F2}", average);
    }
}