using System;

class PointInCircle
{
    static void Main()
    {
        double X = double.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());
        double circle_R = 2;

        if (X*X + Y*Y <= circle_R*circle_R)
        {
            Console.WriteLine("Point is inside the circle");
        }
        else
        {
            Console.WriteLine("Point is NOT inside the circle");
        }
    }
}

