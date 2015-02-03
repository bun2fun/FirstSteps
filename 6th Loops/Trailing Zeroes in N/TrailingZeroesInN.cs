using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger divider = 5;
        BigInteger sum = 0;
        BigInteger result = 1;
        BigInteger factorial = 1;

        while (result > 0)
        {
            sum += (n / divider);
            result = n / divider;
            divider *= 5;
        }
        Console.WriteLine("trailing zeroes of n!: {0}", sum);

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("n! = {0}", factorial);
    }
}
