using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Biggest:");
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Biggest:");
                Console.WriteLine(c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("Biggest:");
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Biggest:");
                Console.WriteLine(c);
            }
        }
    }
}
