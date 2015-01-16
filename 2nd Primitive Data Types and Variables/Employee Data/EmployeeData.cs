using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 20;
        bool isMale = true;
        string IDnumber = "8306112507";
        int employeeNumber = 27569999;

        Console.WriteLine("First Name:{0}", firstName);
        Console.WriteLine("Last Name:{0}", lastName);
        Console.WriteLine("Age:{0}", age);
        Console.WriteLine("The employee is male:{0}", isMale);
        Console.WriteLine("ID number:{0}", IDnumber);
        Console.WriteLine("Employee number:{0}", employeeNumber);
    }
}