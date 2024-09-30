// using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Types;

using Point = (int X, int Y);

public static class Types
{
    public static (Point p1, Point p2, Point p3) Tuples()
    {
        (int X, int Y) point1 = (1,2);
        var point2 = (X: 3, Y: 4);
        Point point3 = (5, 6);
        int X = 7, Y = 8;
        var point4 = (X, Y);
        (int, int) point5 = (9, 10);
        Point point6 = point1;

        bool b1 = point6 == point1;
        bool b2 = point1 == point2;

        // Tuple deconstruction
        (int p1x, int p1y) = point1;
        var (p2x, p2y) = point2;
        (int p3x, _) = point3;

        Console.WriteLine($"point1 == ({point1.X}, {point1.Y})");
        Console.WriteLine($"point2 == ({point2.X}, {point2.Y})");
        Console.WriteLine($"point3 == ({point3.X}, {point3.Y})");
        Console.WriteLine($"point4 == ({point4.X}, {point4.Y})");
        Console.WriteLine($"point5 == ({point5.Item1}, {point5.Item2})");
        Console.WriteLine($"b1 == {b1}, b2 == {b2}");
        Console.WriteLine($"p1x == {p1x}, p1y == {p1y}");
        Console.WriteLine($"p2x == {p2x}, p2y == {p2y}");

        return (point1, point2, point3);
    }

    public static dynamic Dynamic()
    {
        dynamic d1 = 1;

        d1 = "d1";

        return d1;
    }

    public static object Object()
    {
        object o1 = 2;
        o1 = "o1";

        return o1;
    }
}
