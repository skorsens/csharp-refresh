namespace Operators;


public static class Operators
{
    public static (int, int, int) BasicArithmetic()
    {
        int v = 1;
        int v1, v2, v3;

        v1 = v;        
        Console.WriteLine($"v == {v1}");
        v2 = v++;
        Console.WriteLine($"v++ == {v2}");
        Console.WriteLine($"v == {v}");
        v3 = ++v;
        Console.WriteLine($"++v == {v3}");

        return (v1, v2, v3);
    }

    public static (int, int, int, int, int, int, int) BinaryArithmetic()
    {
        int i1 = 1;
        int i2 = 2;

        int i11, i12, i13, i14, i15, i16, i17;

        i11 = ~i1;
        Console.WriteLine($"~i1 == {i11}");
        i12 = i1 & i2;
        Console.WriteLine($"i1 & i2 == {i12}");
        i13 = i1 | i2;
        Console.WriteLine($"i1 | i2 == {i13}");
        i14 = i1 ^ i2;
        Console.WriteLine($"i1 ^ i2 == {i14}");
        i15 = i1 << 1;
        Console.WriteLine($"i1 << 1 == {i15}");
        i16 = i1 >> 1;
        Console.WriteLine($"i1 >> 1 == {i16}");
        i17 = i1 >>> 1;
        Console.WriteLine($"i1 >>> 1 == {i17}");
        
        return (i11, i12, i13, i14, i15, i16, i17);
    }

}