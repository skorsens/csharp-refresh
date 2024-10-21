using System.Runtime.Intrinsics.Arm;

namespace Classes;


public class ClassWithExplicitConstructor
{
    public ClassWithExplicitConstructor(double f1, int f2)
    {
        _f1 = f1;
        _f2 = f2;
    }

    private double _f1;
    private int _f2;

    public double F1 => _f1;
    public int F2 => _f2;

}


public class ClassWithPrimaryConstructor(double f1, int f2)
{
    public double F1 { get; set; } = f1;
    public int F2 {get; set; } = f2;

    public int M1(){
        return F2;
        // Using the f1 below would capture f1 as an instance field,
        // resulting in having 2 fields F1 and f1
        // return f1;
    }
}


public record class RecordClassWithCopyConstructor(int F1, int F2)
{
    public RecordClassWithCopyConstructor(RecordClassWithCopyConstructor r)
    {
        F1 = r.F1;
        F2 = r.F2;
    }
}


public class ClassWithCopyConstructor
{
    public int F1 { get; set; }
    public int F2 { get; set; }

    public ClassWithCopyConstructor(int f1, int f2)
    {
        F1 = f1;
        F2 = f2;
    }
    public ClassWithCopyConstructor(ClassWithCopyConstructor c1)
    {
        F1 = c1.F1;
        F2 = c1.F2;
    }
}


public class ClassWithChainedConstructors
{
    public int F1 { get; set; }
    public int F2 { get; set; }

    public ClassWithChainedConstructors(int f1, int f2)
    {
        F1 = f1;
        F2 = f2;
    }

    public ClassWithChainedConstructors(int f1) : this(f1, -1){}

    public ClassWithChainedConstructors() : this(-1, -2){}
}


public class ClassWithPrimaryAndAnotherConstructor(int f1, int f2)
{
    /* A non-primary constructor of a class with a primary constructor
       must chained-call the primary constructor
    */
    private int F1 { get; set; } = f1;
    private int F2 { get; set; } = f2;

    public ClassWithPrimaryAndAnotherConstructor(ClassWithPrimaryAndAnotherConstructor c1): this(c1.F1, c1.F2){}
}


public class ClassWithStaticConstructor
{
    public static int F1 { get; set; }
    public static int F2 { get; set; }

    static ClassWithStaticConstructor()
    {
        F1 = 1;
    }
}
