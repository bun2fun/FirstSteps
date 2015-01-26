using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient c:");
        double c = double.Parse(Console.ReadLine());

        double x1 = 0;
        double x2 = 0;
        double sqrt = (b * b) - (4 * (a * c));

        if (sqrt < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            x1 = ((-b) - Math.Sqrt(sqrt)) / (2 * a);
            x2 = ((-b) + Math.Sqrt(sqrt)) / (2 * a);
            if (x1 == x2)
            {
                Console.WriteLine("x1=x2={0}", x2);
            }
            else
            {
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
        }
    }
}
