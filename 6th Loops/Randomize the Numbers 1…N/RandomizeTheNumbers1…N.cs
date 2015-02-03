using System;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number n:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Random number = new Random();

        for (int i = 1; i <= n; i++)
        {
            array[i - 1] = i;
        }
        for (int i = array.Length; i > 1; i--)
        {
            // Pick random element to swap.
            int j = number.Next(i); // 0 <= j <= i-1
            // Swap.
            int tmp = array[j];
            array[j] = array[i - 1];
            array[i - 1] = tmp;
        }
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
