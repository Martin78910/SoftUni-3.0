using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public double Distance(Point q)
    {
        double deltaX = this.X - q.X;
        double deltaY = this.Y - q.Y;

        return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
    }

    public override string ToString()
    {
        return string.Format("({0}, {1})", this.X, this.Y);
    }
}

/*
 * Write a program to read n points and print the closest two of them
 */
public class ClosestTwoPoints
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Point[] points = new Point[n];

        for (int i = 0; i < n; i++)
        {
            points[i] = ReadPoint();
        }

        Point[] closestPoints = new Point[2];
        closestPoints[0] = points[0];
        closestPoints[1] = points[1];

        double closestDistance = points[0].Distance(points[1]);

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                double distance = points[i].Distance(points[j]);

                if (distance < closestDistance)
                {
                    closestDistance = distance;

                    closestPoints[0] = points[i];
                    closestPoints[1] = points[j];
                }
            }
        }

        Console.WriteLine("{0:F3}", closestDistance);
        Console.WriteLine(closestPoints[0]);
        Console.WriteLine(closestPoints[1]);
    }

    private static Point ReadPoint()
    {
        int[] pointCoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Point p = new Point() { X = pointCoordinates[0], Y = pointCoordinates[1] };

        return p;
    }
}