using System;
using System.Numerics;

class BitsExchange
{
    static void Main()
    {

        UInt32 number = UInt32.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        UInt32 oneDigitBit = 0;
        UInt32 twoDigitBit = 0;

        for (int i = 3, j = 24; i <= 5 || j <= 26; i++, j++)
        {
            UInt32 mask1 = 1;
            mask1 = mask1 << i;
            oneDigitBit = (mask1 & number) >> i;

            UInt32 mask2 = 1;
            mask2 = mask2 << j;
            twoDigitBit = (mask2 & number) >> j;

            if (oneDigitBit == 0 && twoDigitBit == 1)
            {
                number = mask1 | number;
                number = ~mask2 & number;
            }
            else if (oneDigitBit == 1 && twoDigitBit == 0)
            {
                number = ~mask1 & number;
                number = mask2 | number;
            }
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);
    }
}
