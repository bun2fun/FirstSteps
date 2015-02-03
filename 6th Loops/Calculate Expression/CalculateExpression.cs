using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateExpression
{
    static void Main()
    {
        Console.WriteLine("Enter the number n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number x:");
        int x = int.Parse(Console.ReadLine());

        double s = 0;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            s += factorial / Math.Pow(x, i);
        }
        Console.WriteLine();
        Console.WriteLine("S={0:F5}", s + 1);
    }
}
