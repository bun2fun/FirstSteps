using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter the value of a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of b:");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double c = a + b;
            b = c - b;
            a = c - a;
        }
        Console.WriteLine("a={0} b={1}", a, b);
    }
}
