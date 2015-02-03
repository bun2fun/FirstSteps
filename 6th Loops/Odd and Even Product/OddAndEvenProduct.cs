using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter n number of integers on a single line separated by a space:");
        string entry = Console.ReadLine();

        string[] array = entry.Split(new char[] { ' ' });
        int evenProduct = 1;
        int oddProduct = 1;
        
        for (int i = 1; i <= array.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= int.Parse(array[i - 1]);
            }
            else if (i % 2 == 1)
            {
                oddProduct *= int.Parse(array[i - 1]);
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
