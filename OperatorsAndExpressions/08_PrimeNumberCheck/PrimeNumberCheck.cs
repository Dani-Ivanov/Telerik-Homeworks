using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Is {0} prime number: {1}", n, IsPrime(n));
    }
    static bool IsPrime(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0 && i != number) return false;
        }
        return true;
    }
}

