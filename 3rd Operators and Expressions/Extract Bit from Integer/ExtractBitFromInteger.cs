using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        uint entry = 0;
        Console.WriteLine("Enter a random integer:");
        entry = uint.Parse(Console.ReadLine());
        int bitIndexP = 0;
        Console.WriteLine("Enter the bit index:");
        bitIndexP = int.Parse(Console.ReadLine());

        uint movedBits = 0;
        uint result = 0;

        movedBits = entry >> bitIndexP;
        result = movedBits & 1;

        Console.Write("Binary representation: ");
        Console.WriteLine(Convert.ToString(entry, 2));
        Console.WriteLine("Bit #{0}: {1}", bitIndexP, result);
    }
}