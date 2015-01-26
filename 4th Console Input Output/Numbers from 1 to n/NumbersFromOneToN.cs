using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter the number n:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("sum");
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
