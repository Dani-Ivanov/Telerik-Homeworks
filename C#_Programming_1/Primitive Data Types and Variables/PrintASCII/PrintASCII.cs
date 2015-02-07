using System;

class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine(Convert.ToChar(i));
            
        }
    }
}
