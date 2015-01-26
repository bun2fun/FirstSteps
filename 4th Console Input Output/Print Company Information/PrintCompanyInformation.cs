using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Web site:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager's first name:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Manager's last name:");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Manager's age:");
        string managerAge = Console.ReadLine();
        Console.WriteLine("Manager's phone:");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
            companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
