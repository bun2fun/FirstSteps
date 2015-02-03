using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int divisorA = 0;
        int divisorB = 0;
        List<int> divisors = new List<int>();
        
        if (a == 0)
        {
            Console.WriteLine(b);
        }
        if (b == 0)
        {
            Console.WriteLine(a);
        }
        if (a == b)
        {
            Console.WriteLine(a);
        }
        if (a < 0)
        {
            a *= -1;
        }
        if (b < 0)
        {
            b *= -1;
        }
        if (a >= b)
        {
            for (int i = 1; i <= b; i++)
            {
                divisorA = a % i;
                divisorB = b % i;

                if (divisorA == 0 && divisorB == 0)
                {
                    divisors.Add(i);
                }
            }
        }
        else
        {
            for (int i = 1; i <= a; i++)
            {
                divisorA = a % i;
                divisorB = b % i;

                if (divisorA == 0 && divisorB == 0)
                {
                    divisors.Add(i);
                }
            }
        }
        Console.WriteLine(divisors.Max<int>());
    }
}

