using System;

class ExtractBitFromInt
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;

        if (v == 0)
        {
            mask = ~mask;
            number &= mask;
        }
        else
        {
            number |= mask;
        }
        
        Console.WriteLine(number);
    }
}