using System;

class PointInACircle
{
    static void Main()
    {
        double radius = 2;
        double x = 0;
        double y = 0;

        Console.WriteLine("Enter value for x:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for y:");
        y = double.Parse(Console.ReadLine());

        bool isInside = ((x * x) + (y * y) <= (radius * radius));
        Console.WriteLine("Inside? {0}", isInside);
    }
}
