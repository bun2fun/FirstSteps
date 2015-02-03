using System;

class Program
{
    static void Main()
    {

        int cardSuite = 4;
        char blackSpade = '\u2660';
        char blackClub = '\u2663';
        char redHeart = '\u2665';
        char redDimond = '\u2666';
        string[] cardNotation = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i < cardNotation.Length; i++)
        {
            for (int j = 1; j <= cardSuite; j++)
            {
                Console.Write(cardNotation[i]);
                switch (j)
                {
                    case 1: Console.Write(blackClub + " ");
                        break;
                    case 2: Console.Write(redDimond + " ");
                        break;
                    case 3: Console.Write(redHeart + " ");
                        break;
                    case 4: Console.WriteLine(blackSpade + " ");
                        break;
                }
            }
        }
    }
}