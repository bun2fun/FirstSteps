using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? numberInteger = null;
        double? numberDouble = null;
        Console.WriteLine("Printing integer value null:", numberInteger);
        Console.WriteLine("Printing double value null:", numberDouble);

        Console.WriteLine("If we add value to integer assigned with null, the result is:{0}", numberInteger + 5);
        Console.WriteLine("If we add value to double assigned with null, the result is:{0}", numberDouble + 7);
        Console.WriteLine();
        Console.WriteLine("If we use GetValueOrDefault() the result is:");
        Console.WriteLine(numberInteger.GetValueOrDefault() + 5);
        Console.WriteLine(numberDouble.GetValueOrDefault() + 7);
    }
}