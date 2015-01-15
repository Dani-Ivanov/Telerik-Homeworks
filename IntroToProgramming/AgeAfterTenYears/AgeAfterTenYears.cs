using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthDate;
        DateTime todayDate = DateTime.Today;
        int age;
        int leapDays = 0;

        Console.WriteLine("Enter your birthday(MM/DD/YYYY):");
        birthDate = Convert.ToDateTime(Console.ReadLine());

        for (int i = birthDate.Year; i <= todayDate.Year; i++)
        {
            leapDays += DateTime.IsLeapYear(i) ? 1 : 0;
        }

        age = (todayDate.Subtract(birthDate).Days - leapDays) / 365;
        Console.WriteLine("Your age is {0} and in 10 years it will be {1}", age, age + 10);
    }
}

