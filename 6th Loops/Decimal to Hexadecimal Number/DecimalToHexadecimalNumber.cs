using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string numberToString = number.ToString();
        long remainder = 0;
        long value = 0;
        char symbol;
        string decimalValue = "";

        for (int i = 0; i < numberToString.Length; i++)
        {
            remainder = number % 16;
            number = number / 16;
            value = number;

            if (remainder > 9)
            {
                symbol = (char)(remainder + 55);
                decimalValue += symbol.ToString();

            }
            else
            {
                if (remainder > 0)
                {
                    decimalValue += remainder.ToString();

                }
            }
        }
        string output = new string(decimalValue.ToCharArray().Reverse().ToArray());
        Console.WriteLine(output);
    }
}
