using System;
using System.Linq;
using System.Numerics;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] array = input.ToCharArray();
        BigInteger number = 0;
        BigInteger bit = 0;
        int position = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            bit = array[i] - 48;
            BigInteger bitPower = (BigInteger)Math.Pow(2, position);
            number += bit * bitPower;
            position++;
        }
        Console.WriteLine((long)number);
    }
}

