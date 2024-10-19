namespace Classes;


public readonly struct Point(double x, double y): IEquatable<Point>
{
    public double X => x;
    public double Y => y;

    public bool Equals(Point p) => p.X == X && p.Y == Y;
    public override bool Equals(object? o) => o is Point p && this.Equals(p);
    public override int GetHashCode() => HashCode.Combine(X,Y);

    public static bool operator ==(Point a, Point b) => a.Equals(b);
    public static bool operator !=(Point a, Point b) => !(a == b);
}


public record struct RecordPoint(double X, double Y);
