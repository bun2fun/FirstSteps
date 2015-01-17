using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number = 0;
        int primeNumberDividers = 0;
        Console.WriteLine("Enter an integer in the range 1-100:");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                primeNumberDividers++;
            }
        }
        if (primeNumberDividers == 2)
        {
            Console.WriteLine("Entered Number is a Prime Number: True");
        }
        else
        {
            Console.WriteLine("Entered Number is a Prime Number: False");
        }
    }
}