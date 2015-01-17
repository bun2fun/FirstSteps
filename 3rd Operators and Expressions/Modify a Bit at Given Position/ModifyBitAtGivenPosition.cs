using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        uint entry = 0;
        Console.WriteLine("Enter a random integer:");
        entry = uint.Parse(Console.ReadLine());
        int bitIndexP = 0;
        Console.WriteLine("Enter the bit index:");
        bitIndexP = int.Parse(Console.ReadLine());
        int bitValueV = 0;
        Console.WriteLine("Enter the bit value 0 or 1:");
        bitValueV = int.Parse(Console.ReadLine());

        int mask = 0;
        long result = 0;

        if (bitValueV == 1)
        {
            mask = 1 << bitIndexP;
            result = mask | entry;
        }
        else
        {
            mask = 1 << bitIndexP;
            result = ~mask & entry;
        }
        Console.WriteLine("Binary representation: ");
        Console.WriteLine(Convert.ToString(entry, 2).PadLeft(16, '0'));
        //Console.WriteLine("Binary result:  ");
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.WriteLine("Result: {0}", result);
    }
}
