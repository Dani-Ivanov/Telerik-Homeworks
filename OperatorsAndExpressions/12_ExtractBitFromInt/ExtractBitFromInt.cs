using System;

class ExtractBitFromInt
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int bit = number & mask;
        bit >>= p;
        Console.WriteLine(bit);
    }
}

