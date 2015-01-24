using System;


class SwapVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("a = {0},b = {1}", a, b);

        Swap<int>(ref a,ref b);
        

        Console.WriteLine("after Swap function a = {0},b = {1}", a, b);

    }
    static void Swap<T>(ref T a,ref T b)
    {
        T c = a;
        a = b;
        b = c;
    }
}

