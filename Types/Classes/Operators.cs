using System.Threading.Channels;

namespace Classes;


public class ClassWithOperators(int _state)
{
    public int State { get; } = _state;

    public static ClassWithOperators operator +(ClassWithOperators c1, ClassWithOperators c2)
    {
        return new ClassWithOperators(c1.State + c2.State);
    }

    public static ClassWithOperators operator +(ClassWithOperators c, int i)
    {
        return new ClassWithOperators(c.State + i);
    }

    public static ClassWithOperators operator +(int i, ClassWithOperators c)
    {
        return new ClassWithOperators(c.State + i);
    }

    public static explicit operator int(ClassWithOperators c)
    {
        return c.State;
    }

    public static bool operator >(ClassWithOperators c1, ClassWithOperators c2)
    {
        return c1.State > c2.State;
    }

    public static bool operator <(ClassWithOperators c1, ClassWithOperators c2)
    {
        return c1.State < c2.State;
    }

    public static bool operator true(ClassWithOperators c1)
    {
        return c1.State > 5;
    }

    public static bool operator false(ClassWithOperators c1)
    {
        return c1.State < 5;
    }
}
