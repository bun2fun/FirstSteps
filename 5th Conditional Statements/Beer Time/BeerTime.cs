using System;
using System.Threading;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Please enter the time in the following format: hh:mm tt");
        string entry = Console.ReadLine();
        DateTime startHour = Convert.ToDateTime("13:00:00");
        DateTime endHour = Convert.ToDateTime("03:00:00");
        try
        {
            DateTime beerTime = Convert.ToDateTime(entry);

            if (beerTime.TimeOfDay >= startHour.TimeOfDay || beerTime.TimeOfDay < endHour.TimeOfDay)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Sorry, invalid time");
        }
    }
}