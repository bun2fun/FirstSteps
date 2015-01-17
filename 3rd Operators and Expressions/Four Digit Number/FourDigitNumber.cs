using System;

class FourDigitNumber
{
    static void Main()
    {
        int fourDigitNumber = 0;
        int sum = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;

        fourDigitNumber = int.Parse(Console.ReadLine());

        a = (fourDigitNumber / 1000) % 10;
        b = (fourDigitNumber / 100) % 10;
        c = (fourDigitNumber / 10) % 10;
        d = fourDigitNumber % 10;
        sum = a + b + c + d;
        Console.Write("n = {0}, Sum = {1}, ", fourDigitNumber, sum);
        Console.Write("Reversed = {0}{1}{2}{3}, ", d, c, b, a);
        Console.Write("Last digit in front = {0}{1}{2}{3}, ", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged = {0}{1}{2}{3}, ", a, c, b, d);
    }
}
