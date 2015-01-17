using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int number = 0;
        number = int.Parse(Console.ReadLine());
        bool isEven = (number % 2 != 0);
        Console.WriteLine("Odd? {0}", isEven);
    }
}
