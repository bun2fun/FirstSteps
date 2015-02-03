using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter the number of integers:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the min value:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the max value:");
        int max = int.Parse(Console.ReadLine());

        if (min <= max)
        {
            Console.WriteLine("Random numbers:");
            Random number = new Random();

            for (int i = 0; i < n; i++)
            {
                int generator = number.Next(min, max + 1);
                Console.Write(generator + " ");
            }
        }
        else
        {
            Console.WriteLine("The max value should be greater than the min value.");
        }
    }
}
