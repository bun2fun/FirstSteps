using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        decimal balance = 309457034976.45m;
        string bankName = "OBB";
        string iban = "BG34UBBS983475653";
        string numberCC1 = "1234 5678 9900";
        string numberCC2 = "5555 4444 6666";
        string numberCC3 = "3333 8888 9999";

        Console.WriteLine("First Name:{0}", firstName);
        Console.WriteLine("Middle Name:{0}", middleName);
        Console.WriteLine("Last Name:{0}", lastName);
        Console.WriteLine("Your balance is:{0}", balance);
        Console.WriteLine("Your bank name is:{0}", bankName);
        Console.WriteLine("Your IBAN is:{0}", iban);
        Console.WriteLine("Your 1st Credit Card number is:{0}", numberCC1);
        Console.WriteLine("Your 2st Credit Card number is:{0}", numberCC2);
        Console.WriteLine("Your 3st Credit Card number is:{0}", numberCC3);
    }
}
