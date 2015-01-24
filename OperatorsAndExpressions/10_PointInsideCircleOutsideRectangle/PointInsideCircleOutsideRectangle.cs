using System;


class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        double X = double.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());

        Console.WriteLine(IsInsideCircle(X,Y) && OutSideOfRect(X,Y));
    }
    static bool IsInsideCircle(double x, double y)
    {
        double circle_r = 1.5;
        double circle_x = 1;
        double circle_y = 1;

        x = x - circle_x;
        y = y - circle_y;

        if (x * x + y * y <= circle_r)
        {
            return true;
        }
        return false;
    }
    static bool OutSideOfRect(double x, double y)
    {
        //R(x=1, y=-1, width=6, height=2)

        if ((y < 1 || y > -3) && (x > -1 || x < 7))
        {
            return true;
        }
        return false;
    }
}
