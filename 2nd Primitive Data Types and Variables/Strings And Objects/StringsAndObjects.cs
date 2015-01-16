using System;

class StringsAndObjects
{
    static void Main()
    {
        string greeting = "Hello";
        string noun = "World";
        object obj = greeting + " " + noun;
        string castObjToString = obj.ToString();
        Console.WriteLine(castObjToString);
    }
}