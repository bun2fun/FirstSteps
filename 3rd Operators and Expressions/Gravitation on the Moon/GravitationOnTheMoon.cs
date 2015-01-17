using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weight = 0;
        weight = double.Parse(Console.ReadLine());

        double moonWeight = weight * 17 / 100;
        Console.WriteLine(moonWeight);
    }
}
