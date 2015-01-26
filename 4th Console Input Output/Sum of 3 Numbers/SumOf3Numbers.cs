using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;
        Console.WriteLine("a={0}, b={1}, c={2}, sum={3}", a, b, c, sum);
    }
}
