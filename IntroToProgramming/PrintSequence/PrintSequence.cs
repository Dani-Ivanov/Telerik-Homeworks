using System;

class PrintSequence
{
    static void Main()
    {
        int signHolder = 1;

        for (int i = 2; i < 12; i++)
        {
            Console.Write(i * signHolder + ", ");
            signHolder *= -1;
        }
    }
}

