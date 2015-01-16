using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a={0} \nb={1}", a, b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("After exchanging their values:\na={0} \nb={1}", a, b);
    }
}
