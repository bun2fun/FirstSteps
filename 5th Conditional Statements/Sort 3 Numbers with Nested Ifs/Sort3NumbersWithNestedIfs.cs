using System;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if ((a >= b && a >= c))
        {
            if (b >= c)
            {
                Console.WriteLine("Result:");
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (c > b)
            {
                Console.WriteLine("Result:");
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }
        if (b >= a && b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine("Result:");
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else if (c > a)
            {
                Console.WriteLine("Result:");
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        if (c >= a && c >= b)
        {
            if (a >= b)
            {
                Console.WriteLine("Result:");
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else if (b > a)
            {
                Console.WriteLine("Result:");
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}