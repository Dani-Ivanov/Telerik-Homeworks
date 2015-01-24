using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k = ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            exchangeBits(ref n, p++, q++);
        }

        Console.WriteLine(n);
    }
    static void exchangeBits(ref int num, int p, int q)
    {
        int mask = 1;
        int bitP = num & (mask << p);
        bitP >>= p;
        int bitQ = num & (mask << q);
        bitQ >>= q;

        if (bitQ == 0)
        {
            mask = ~(mask << p);
            num &= mask;
        }
        else
        {
            mask <<= p;
            num |= mask;
        }
        mask = 1;
        if (bitP == 0)
        {
            mask = ~(mask << q);
            num &= mask;
        }
        else
        {
            mask <<= q;
            num |= mask;
        }
    }
}