using System;

class Trapezoids
{
    static void Main()
    {
        double a = 0;
        double b = 0;
        double h = 0;
        double area = 0;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());

        area = ((a + b) / 2) * h;

        Console.WriteLine("a = {0}; b = {1}; h = {2}; area = {3}", a, b, h, area);
    }
}
