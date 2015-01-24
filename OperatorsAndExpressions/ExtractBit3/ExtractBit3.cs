using System;

class ExtractBit3
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int bit = number & mask;
        bit >>= p;
        Console.WriteLine(bit);
    }
}