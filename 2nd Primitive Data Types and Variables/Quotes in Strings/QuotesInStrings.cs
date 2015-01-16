using System;

class QuotesInStrings
{
    static void Main()
    {
        string version1 = "The \"use\" of quotations causes difficulties.";
        string version2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(version1);
        Console.WriteLine(version2);
    }
}
