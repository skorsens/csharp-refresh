namespace Classes;


public static class ClassWithMethods
{
    public static int MethodWithOutParameter(int i1, out int i2)
    {
        // - `out` parameters allow passing arguments by reference
        // - `out` parameters are used to only return a values from methods
        // - A method must assign a value to all out parameters (ulike ref parameters)
        // - In a method out parameters have no values (ref parameters do have)
        i2 = i1 + 2;
        return i1 + 1; 
    }

    public static int MethodWithUnAssignedRefParameter(int i1, ref int i2)
    {
        // - `ref` parameters allow passing arguments by reference
        // - `ref` parameters are used to pass and return arguments to/from methods
        // - A method does not have to assign a value to a ref parameter
        return i1 + i2;
    }

    public static int MethodWithAssignedRefParameter(int i1, ref int i2)
    {
        // - A method does not have to assign a value to a ref parameter
        i2++;
        return i1 + i2;
    }

    public static int MethodWithInParameter(in int i1)
    {
        // - `in` parameters allow passing arguments by reference
        // - `in` parameters are used to only pass arguments to methods
        // methods cannot modify `in` parameters
        // - `in` parameters are useful for value type arguments such that sizeof(argument)  >= sizeof(pointer)
        // E.g. `in int i1` is useless, since sizeof(ref(int)) == sizeof(int)
        // - `in` parameters allow passing value arguments, e.g. `MethodWithInParameter(3)`
        // - `in` parameters shall be used with readonly value type arguments only;
        // using them with mutable arguments is useless, since this does not prevent copying
        // the arguments because the compiler cannot guarantee that the argument is not changed
        // by one of its methods
        // - `ref readonly` parameters are similar to `in` parameters
        return i1 + 2;
    }

    public static int MethodWithRefReadonlyParameter(ref readonly int i1)
    {
        // - `ref readonly` parameters are similar to `in` parameters, but
        // they do not allow value arguments
        return i1 + 2;
    }

    public static int MethodWithRefReferenceParameter(ref Counter c)
    {
        int i = c.GetNext();

        c = new Counter(1);
        
        return i;
    }

    public static int MethodWithOutReferenceParameter(out Counter c)
    {
        int i = 0;

        c = new Counter(1);
        
        return i;
    }

    public static int MethodWithOptionalParameters(int i1 = 1, int i2 = 2)
    {
        return i1 + i2;
    }

    public static int MethodOverloaded()
    {
        return 1;
    }

    public static int MethodOverloaded(int i)
    {
        return i;
    }

    public static int MethodWithVariableArgumentsCount(int i, params int[] args)
    {
        int s = 0;

        foreach (int e in args)
        {
            s += e;
        }
        return i + s;
    }

    public static int MethodExtension(this int i)
    {
        return i + 1;
    }
}
