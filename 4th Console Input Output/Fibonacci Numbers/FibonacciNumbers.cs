using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of the sequence:");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int fibonacci1 = -1;
        int fibonacci2 = 1;

        for (int i = 0; i < number; i++)
        {
            sum = fibonacci1 + fibonacci2;
            fibonacci1 = fibonacci2;
            fibonacci2 = sum;

            Console.Write(fibonacci2 + " ");
        }
    }
}