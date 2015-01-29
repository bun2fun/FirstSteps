using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter score in the range 1-9:");
        int score = int.Parse(Console.ReadLine());
        int result = 0;
        if (score > 0 && score < 10)
        {
            if (score > 0 && score < 4)
            {
                result = score * 10;
                Console.WriteLine("score={0} result={1}", score, result);
            }
            if (score > 3 && score < 7)
            {
                result = score * 100;
                Console.WriteLine("score={0} result={1}", score, result);
            }
            if (score > 6 && score < 10)
            {
                result = score * 1000;
                Console.WriteLine("score={0} result={1}", score, result);
            }
        }
        else
        {
            Console.WriteLine("Invalid score.");
        }
    }
}
