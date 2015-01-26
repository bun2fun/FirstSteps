using System;

class NumbersDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first number of the sequesnce:");
        int entry1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the last number of the sequesnce:");
        int entry2 = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = entry1; i <= entry2; i++)
        {
            if (i % 5 == 0)
            {
                sum++;
                Console.Write("{0}, ", i);
            }
        }
        if (sum == 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("p={0}", sum);
        }
    }
}