using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] characters = input.ToCharArray();
        char symbol;
        int value = 0;
        int position = 0;
        long number = 0;

        for (int i = characters.Length - 1; i >= 0; i--)
        {
            symbol = characters[i];
            if (symbol > 48 && symbol < 58)
            {
                value = symbol - 48;
            }
            if (symbol > 64 && symbol < 71)
            {
                value = symbol - 55;
            }
            number += value * (long)Math.Pow(16, position);
            position++;
        }
        Console.WriteLine(number);
    }
}