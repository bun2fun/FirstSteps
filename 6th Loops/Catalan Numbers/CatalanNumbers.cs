using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number n in the range 2 - 99:");
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 0;
        BigInteger factorialN = 1;
        BigInteger factorial2N = 1;
        BigInteger factorialN1 = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        for (int i = 1; i <= n * 2; i++)
        {
            factorial2N *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            factorialN1 *= i;
        }
        result = factorial2N / (factorialN1 * factorialN);
        Console.WriteLine("Catalan(n)={0}", result);
    }
}
