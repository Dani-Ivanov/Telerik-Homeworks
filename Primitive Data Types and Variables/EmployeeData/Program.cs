using System;


class EmployeeData
{
    static void Main()
    {
        string EmpFristName = "Pesho";
        string EmpLastName = "Ivanov";
        ushort EmpAge = 37;
        char EmpGender = 'm';
        long EmpID = 8306112507;
        uint EmpUniqueNumb = 27569999;

        Console.WriteLine("First name = {0} \nLast name = {1} \nAge = {2} \nGender = {3} \nPersonal ID number = {4}\nUnique employee number = {5}", EmpFristName,EmpLastName,EmpAge,EmpGender,EmpID,EmpUniqueNumb);
    }
}

