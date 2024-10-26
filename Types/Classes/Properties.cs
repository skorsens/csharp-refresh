using System.ComponentModel;

namespace Classes;


public class ClassWithProperties
{
    private int _i;

    public int ExplicitProperty
    {
        get
        {
            return _i;
        }

        set
        {
            _i = value;
        }
    }

    public int ExpressionExplicitProperty
    {
        get => _i;
        set => _i = value;
    }

    public int AutoProperty { get; set; }

    public int RoProperty { get; } = 12;

    public ClassWithProperties()
    {
    }

    public ClassWithProperties(int RoPropertyInitializer): this(RoPropertyInitializer, 0)
    {
    }

    public ClassWithProperties(int RoPropertyInitializer, int AutoPropertyInitializer)
    {
        RoProperty = RoPropertyInitializer;
        AutoProperty = AutoPropertyInitializer;
    }

    public int RoPropertyWithInit { get; init; } = 12;

    public string this[string i1, int i2]
    {
        get
        {
            if (i1 == "one" && i2 == 1)
                return "one & 1";
            else
                return i1 + " & " + i2.ToString();
        }
    }

    private int[] _i_for_indexer = [0, 1, 2, 3];

    public int this[int i]
    {
        get => _i_for_indexer.Length < i ? i + 100 : _i_for_indexer[i];
        set => _i_for_indexer[i] = value;
    }
}


public readonly struct RoStructWithInitProperty(int f1, int f2)
{
    /* Init properties enable using the `with` initializer syntax
       for RO struct.
    */
    public int F1 { get; init; } = f1;
    public int F2 { get; init; } = f2;
}
