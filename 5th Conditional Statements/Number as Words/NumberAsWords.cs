using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Enter a digit in the range 0-999:");

        int digit = int.Parse(Console.ReadLine());

        int hundreds = digit / 100;
        int tens = (digit % 100) / 10;
        int units = (digit % 10);

        Console.WriteLine("{0} {1} {2}", hundreds, tens, units);
        if (hundreds == 0 && tens == 0 && units == 0)
        {
            Console.WriteLine("Zero");
        }
        if (hundreds != 0) //checking whether the number consists of 3 digits
        {
            switch (hundreds)
            {
                case 1: Console.Write("one hundred ");
                    break;
                case 2: Console.Write("two hundred ");
                    break;
                case 3: Console.Write("three hundred ");
                    break;
                case 4: Console.Write("four hundred ");
                    break;
                case 5: Console.Write("five hundred ");
                    break;
                case 6: Console.Write("six hundred ");
                    break;
                case 7: Console.Write("seven hundred ");
                    break;
                case 8: Console.Write("eight hundred ");
                    break;
                case 9: Console.Write("nine hundred ");
                    break;
            }
        }
        if (hundreds != 0 && (tens != 0 || (tens == 0 && units != 0))) //checking whether the first two digits from right to left are different than zero
        {
            Console.Write("and ");
        }
        if (tens != 0 && tens != 1) //checking whether the second digit from right to left is different than zero and one
        {
            switch (tens)
            {
                case 2: Console.Write("twenty ");
                    break;
                case 3: Console.Write("thirty ");
                    break;
                case 4: Console.Write("fourty ");
                    break;
                case 5: Console.Write("fifty ");
                    break;
                case 6: Console.Write("sixty ");
                    break;
                case 7: Console.Write("seventy ");
                    break;
                case 8: Console.Write("eighty ");
                    break;
                case 9: Console.Write("ninety ");
                    break;
            }
        }
        if (tens == 1) //when the second digit from right to left is one
        {
            switch (units)
            {
                case 0: Console.WriteLine("ten ");
                    break;
                case 1: Console.WriteLine("eleven");
                    break;
                case 2: Console.WriteLine("twelve");
                    break;
                case 3: Console.WriteLine("thirteen");
                    break;
                case 4: Console.WriteLine("fourteen");
                    break;
                case 5: Console.WriteLine("fifteen");
                    break;
                case 6: Console.WriteLine("sixteen");
                    break;
                case 7: Console.WriteLine("seventeen");
                    break;
                case 8: Console.WriteLine("eighteen");
                    break;
                case 9: Console.WriteLine("nineteen");
                    break;
            }
        }
        if (units != 0 && tens != 1) //checking whether the first digit from right to left is different than zero
        {							// and whether the second one is different than one
            switch (units)
            {
                case 1: Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                case 6: Console.WriteLine("six");
                    break;
                case 7: Console.WriteLine("seven");
                    break;
                case 8: Console.WriteLine("eight");
                    break;
                case 9: Console.WriteLine("nine");
                    break;
            }
        }
    }
}