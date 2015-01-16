using System;
using System.Threading;
using System.Globalization;

class ComparingFloats
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double difference = Math.Abs(a) - Math.Abs(b);
        bool isSignificantDifference = difference < 0.000001;

        Console.WriteLine("The two numbers are considered equal: {0}", isSignificantDifference);
    }
}
