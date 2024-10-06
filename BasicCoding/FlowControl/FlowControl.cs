using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace FlowControl;


public static class FlowControl
{
    public static (bool, bool, bool) IfStatement()
    {
        int i = 10;
        bool r1 = false;
        bool r2 = false;
        bool r3 = false;

        if (i < 11)
            r1 = true;

        if (i < 11)
        {
            r2 = true;
        }

        if (i > 10)
        {
            r3 = false;
        }
        else if (i < 10)
        {
            r3 = false;
        }
        else
        {
            r3 = true;
        }

        return (r1, r2, r3);
    }

    public static int SwitchStatement()
    {
        int k = 5;
        int r1 = 0;

        switch (k)
        {
            case 1:
                r1 = 1;
                break;
            case 2:
            case 3:
                r1 = 2;
                goto case 4;
            case 4:
                r1 = 4;
                break;
            default:
                r1 = k;
                break;
        }

        return r1;
    }

    public static int ForLoop()
    {
        int j = 0;
        for (int i = 0; i < 5; i++)
            j++;

        // "i" does not exist in the current context
        // Console.WriteLine($"i == {i}");

        return j;
    }

    public static int ForeachLoop()
    {
        int[] a = [1,2,3];
        int el = 0;

        foreach (int e in a)
            el = e;

        return el;
    }

    public static int Patterns_Declaration(object o)
    {
        int r;

        switch (o)
        {
            case string s:
                r = 1;
                break;
            case int i:
                r = 2;
                break;
            default:
                r = 0;
                break;
        }

        return r;
    }

    public static int Patterns_Type(object o)
    {
        int r;

        switch (o)
        {
            case string:
                r = 1;
                break;
            case int:
                r = 2;
                break;
            default:
                r = 0;
                break;
        }

        return r;
    }

    public static int Patterns_Positional((int, int) o)
    {
        int r;

        switch (o)
        {
            case (1,1):
                r = 1;
                break;
            case (2,2):
                r = 2;
                break;
            default:
                r = 0;
                break;
        }

        return r;
    }

    public static int Patterns_List(int[] a)
    {
        switch (a)
        {
            case [1, .., 6]:
                return 1;
            case [2, ..int[] a1, 7]:
                return a1[0];
            default:
                return 0;
        }
    }

    public static int Patterns_Property(string s)
    {
        switch (s){
            case string { Length: 1 }:
                return 1;
            case string { Length: 2 }:
                return 2;
            case { Length: 3}:
                return 3;
            default:
                return 0;
        }
    }

    public static int Patterns_Relational(int i)
    {
        switch (i)
        {
            case > 1 and < 3:
                return 1;
            case >= 3:
                return 2;
            default:
                return 0;
        }
    }

    public static int Patterns_SwitchStatement(int i)
    {
        return i switch {
            > 1 and < 3 => 1,
            >= 3 => 2,
            _ => 0,
        };
    }

    public static int Patterns_When(object t)
    {
        switch (t){
            case (int x, int y) when x > y:
                return 1;
            default:
                return 0;
        }
    }
}
