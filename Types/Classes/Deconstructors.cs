using System.Security.Cryptography;

namespace Classes;


public readonly struct Size(double w, double h)
{
    public double W { get; } = w;
    public double H { get; } = h;

    public void Deconstruct(out double w, out double h)
    {
        w = W;
        h = H;
    }

    public static string DescribeSize(Size s) => s switch
    {
        (0, 0) => "Empty",
        (0, _) => "Narrow",
        (double w, 0) => $"Low {w}",
        _ => "Normal"
    };
}


/* `record class` and `record struct` have auto-generated deconstructor */
public record class SizeRecordClass(int W, int H);

public readonly record struct SizeRecordStruct(int W, int H);
