using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the circle's radius:");
        double radius = double.Parse(Console.ReadLine());
        double perimemter = 3.14159 * (radius * 2);
        double area = 3.14159 * (radius * radius);

        Console.WriteLine("r={0:F2}, perimeter={1:F2}, area={2:F2}", radius, perimemter, area);
    }
}