using System;

class ThirdDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n = n / 100;

        if (n % 10 == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

    }
}

