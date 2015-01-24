using System;

class BitAtPositionP
{
    static void Main()
    {
        bool isOne = false;
        int number = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int bit = number & mask;
        bit >>= p;
        isOne = (bit == 1);
        Console.WriteLine(isOne);
    }
}