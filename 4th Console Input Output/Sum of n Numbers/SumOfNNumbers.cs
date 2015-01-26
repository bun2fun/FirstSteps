using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of entries:");
        int howManyNumbers = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the {0} numbers:", howManyNumbers);
        double sum = 0;

        for (int i = 0; i < howManyNumbers; i++)
        {
            double numbers = double.Parse(Console.ReadLine());
            sum += numbers;
        }
        Console.WriteLine(sum);
    }
}
