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

}