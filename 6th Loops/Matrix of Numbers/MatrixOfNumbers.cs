using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number in the range 1-20:");
        int n = int.Parse(Console.ReadLine());
        if (n >= 1 && n <= 20)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");

                for (int j = i + 1; j < n + i; j++)
                {
                    if (j == (n - 1) + i)
                    {
                        Console.WriteLine(j);
                        break;
                    }
                    Console.Write(j + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Try again");
        }
    }
}