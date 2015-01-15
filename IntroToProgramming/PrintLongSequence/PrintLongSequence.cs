using System;

class PrintLongSequence
{
    static void Main()
    {
        int signHolder = 1;

        for (int i = 2; i < 1002; i++)
        {
            Console.Write(i * signHolder + ", ");
            signHolder *= -1;
        }
    }
}
