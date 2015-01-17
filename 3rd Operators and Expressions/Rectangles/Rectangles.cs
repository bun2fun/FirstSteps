using System;

class Rectangles
{
    static void Main()
    {
        double width = 0;
        double height = 0;
        double perimeter = 0;
        double area = 0;

        width = double.Parse(Console.ReadLine());
        height = double.Parse(Console.ReadLine());

        perimeter = (width * 2) + (height * 2);
        area = width * height;

        Console.WriteLine("Perimeter = {0}", perimeter);
        Console.WriteLine("Area = {0}", area);
    }
}
