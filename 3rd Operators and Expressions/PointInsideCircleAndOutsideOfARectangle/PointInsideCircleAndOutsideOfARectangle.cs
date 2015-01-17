using System;

class PointInsideCircleOutsideOfRectangle
{
    static void Main()
    {
        double radius = 1.5;
        double x = 0;
        double y = 0;
        double x1 = 0;
        double y1 = 0;

        Console.WriteLine("Enter value for x:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for y:");
        y = double.Parse(Console.ReadLine());
        x1 = x - 1;
        y1 = y - 1;
        bool isInsideCircle = ((x1 * x1) + (y1 * y1) <= (radius * radius));
        bool isInsideRectangular = ((x <= 5) && (x >= -1)) && ((y <= 1) && (y >= -1));
        if (isInsideCircle && !isInsideRectangular)
        {
            Console.WriteLine("Iinside K & outside of R? Yes");
        }
        else
        {
            Console.WriteLine("Iinside K & outside of R? No");
        }
    }
}
