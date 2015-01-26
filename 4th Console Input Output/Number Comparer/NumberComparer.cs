using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("a={0} b={1} greater=", firstNumber, secondNumber);
        Console.WriteLine(Math.Max(firstNumber, secondNumber));
    }
}
