using System;

class CompareFloats
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(compareFloats(a, b));
    }
    static bool compareFloats(double a, double b)
    {
        double eps = 0.000001;
        if ((a - b) < eps && (a - b) > -eps)
        {
            return true;
        }
        return false;
    }
}
