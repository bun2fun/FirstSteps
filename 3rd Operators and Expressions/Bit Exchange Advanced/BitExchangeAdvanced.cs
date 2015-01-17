using System;
//using System.Numerics;

class BitsExchangeAdvanced
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        int firstSequenceBit = int.Parse(Console.ReadLine());
        int secondSequenceBit = int.Parse(Console.ReadLine());
        int howManyBits = int.Parse(Console.ReadLine());
        long firstResult = 0;
        long secondResult = 0;
        long number = input;
        if (Math.Max(firstSequenceBit, secondSequenceBit) + howManyBits > 32 ||
            Math.Min(firstSequenceBit, secondSequenceBit) < 0)
        {
            Console.WriteLine("out of range");
            return;
        }
        if (Math.Abs(secondSequenceBit - firstSequenceBit) < howManyBits)
        {
            Console.WriteLine("overlapping");
            return;
        }
        for (int i = firstSequenceBit, j = secondSequenceBit;
            i < (firstSequenceBit + howManyBits) || j < (secondSequenceBit + howManyBits);
            i++, j++)
        {
            long mask1 = 1L;
            mask1 = mask1 << i;
            firstResult = (mask1 & number) >> i;

            long mask2 = 1L;
            mask2 = mask2 << j;
            secondResult = (mask2 & number) >> j;

            if (firstResult == 0 && secondResult == 1)
            {
                number = mask1 | number;
                number = ~mask2 & number;
            }
            else if (firstResult == 1 && secondResult == 0)
            {
                number = ~mask1 & number;
                number = mask2 | number;
            }
        }
        Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);
    }
}
