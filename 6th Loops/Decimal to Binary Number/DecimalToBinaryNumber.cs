using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string n = Convert.ToString(number);
        long[] array = new long[64];
        string[] binary = new string[64];

        for (int i = 0; i < 64; i++)
        {
            long remainder = number % 2;
            number = number / 2;
            string bitToString = Convert.ToString(remainder);
            binary[i] = bitToString;
            if (number == 0)
            {
                break;
            }
        }
        for (int i = 0; i < binary.Length; i++)
        {
            Console.Write(binary[(binary.Length - 1) - i]);
        }
    }
}