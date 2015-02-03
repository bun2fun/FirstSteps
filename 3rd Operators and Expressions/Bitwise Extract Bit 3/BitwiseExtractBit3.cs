using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class BitwiseExtractBitNumber3
{
    static void Main()
    {
        uint entry = 0;
        Console.WriteLine("Enter a random integer:");
        entry = uint.Parse(Console.ReadLine());
        uint result = 0;
        uint movedBits = 0;

        movedBits = entry >> 3;
        result = movedBits & 1;

        Console.Write("Binary representation: ");
        Console.WriteLine(Convert.ToString(entry, 2));
        Console.WriteLine("Bit #3: {0}", result);
    }
}
