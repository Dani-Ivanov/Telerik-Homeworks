using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double moonWeight = 17 / 100 * n;

        Console.WriteLine("Your weight on the moon would be {0}.",moonWeight);
    }
}

