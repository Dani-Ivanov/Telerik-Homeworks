using System;
class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("Null a = {0} b = {1}", a, b);

        a += 2;
        b += 2.3;
        Console.WriteLine("Null+int a = {0} b = {1}", a, b);
        a = 5;
        b = 5.5;

        Console.WriteLine("assign values a = {0} b = {1}", a, b);
    }
}