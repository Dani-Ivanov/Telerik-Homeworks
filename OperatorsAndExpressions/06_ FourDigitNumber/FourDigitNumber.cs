using System;

class FourDigitNumber
{
    static void Main()
    {
        string strNumber = Console.ReadLine();
        int number = int.Parse(strNumber);
        int sum = 0;
        char a = strNumber[0];
        char b = strNumber[1];
        char c = strNumber[2];
        char d = strNumber[3];

        for (int i = 0; i < 4; i++)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine("Sum of digits {0}", sum);
        Console.WriteLine("Reversed {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("Last digit in front {3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("Second and third digits exchanged {0}{2}{1}{3}", a, b, c, d);

    }
}

