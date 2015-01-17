using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        int n = 0;
        n = int.Parse(Console.ReadLine());

        bool isSeven = ((n / 100) % 10 == 7);
        Console.WriteLine("Third digit 7? {0}", isSeven);
    }
}

