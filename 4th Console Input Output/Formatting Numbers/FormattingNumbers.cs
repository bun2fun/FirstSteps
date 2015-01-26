using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first number:");
        float thirdNumber = float.Parse(Console.ReadLine());


        Console.Write("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|",
            firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'), secondNumber, thirdNumber);
    }
}
