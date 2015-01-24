using System;

class Rectangles
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double area = a * b;
        double perimeter = (a+b)*2;

        Console.WriteLine("Rectangle's permiter is {0} and his area is {1}", perimeter, area);

    }
}

