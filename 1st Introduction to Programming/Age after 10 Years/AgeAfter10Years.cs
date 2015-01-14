using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime bDate;
        Console.WriteLine("Please enter your birthday in the following format: dd-mm-yyyy:");
        bDate = DateTime.Parse(Console.ReadLine());
        int ageNow = DateTime.Now.Year - bDate.Year;
        int afterTenYears = ageNow + 10;
        
        Console.WriteLine("You are now {0} years old. In ten years you will be {1} years.", ageNow, afterTenYears);
    }
}
