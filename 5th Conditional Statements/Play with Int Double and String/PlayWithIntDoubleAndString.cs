using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int \n2 --> double \n3 --> string");
        int usersChoice = int.Parse(Console.ReadLine());

        switch (usersChoice)
        {
            case 1:
                {
                    Console.WriteLine("Please enter an integer:");
                    int wholeNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", wholeNumber + 1);
                }
                break;
            case 2:
                {
                    Console.WriteLine("Please enter a double:");
                    double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", realNumber + 1);
                }
                break;
            case 3:
                {
                    Console.WriteLine("Please enter a string:");
                    string letters = Console.ReadLine();
                    Console.WriteLine("Result: {0}" + "*", letters);
                }
                break;
            default:
                {
                    Console.WriteLine("Try again!");
                }
                break;
        }
    }
}