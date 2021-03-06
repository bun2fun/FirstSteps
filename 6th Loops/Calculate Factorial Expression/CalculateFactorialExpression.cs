﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    class CalculateFactorialExpression
    {
        static void Main()
	    {
		Console.WriteLine("Enter number n in the range 3 - 99:");
		int n = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter number k in the range 2 - 98:");
		int k = int.Parse(Console.ReadLine());

		BigInteger result = 0;
		BigInteger factorialN = 1;
		BigInteger factorialK = 1;
		BigInteger factorialNK = 1;

		for (int i = 1; i <= n; i++)
		{
			factorialN *= i;
			if (i <= k)
			{
				factorialK *= i;
			}
		}
		for (int i = 1; i <= (n - k); i++)
		{
			factorialNK *= i;
		}
		result = factorialN / (factorialK * factorialNK);
		Console.WriteLine("n! / (k! * (n-k)!) = {0}", result);
	}
}

