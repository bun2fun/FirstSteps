using System;
using System.Linq;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers in a row:");

        var entry = Console.ReadLine().Split().Take(5);
        Double[] numbers = entry.Select(n => Convert.ToDouble(n)).ToArray();
        double sum = numbers.Sum();

        Console.WriteLine("{0}", sum);
    }
}

