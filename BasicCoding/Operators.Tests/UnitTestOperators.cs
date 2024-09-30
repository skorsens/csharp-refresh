namespace Operators.Tests;

[TestClass]
public class UnitTestOperators
{
    [TestMethod]
    public void TestBasicArithmetic()
    {
        (int v1, int v2, int v3) = Operators.BasicArithmetic();

        Assert.AreEqual(v1, 1);
        Assert.AreEqual(v2, 1);
        Assert.AreEqual(v3, 3);
    }

    [TestMethod]
    public void TestBinaryArithmetic()
    {
        var (i11, i12, i13, i14, i15, i16, i17) = Operators.BinaryArithmetic();

        Assert.AreEqual((i11, i12, i13, i14, i15, i16, i17), (-2, 0, 3, 3, 2, 0, 0));
    }

    [TestMethod]
    public void TestBoolArithmetic()
    {
        var (b1, b2, b3, b4, b5) = Operators.BoolArithmetic();

        Assert.AreEqual((b1, b2, b3, b4, b5), (false, false, true, false, false));
    }

    [TestMethod]
    public void TestRelational()
    {
        var (s1, s2, i1, i2) = Operators.Relational();

        Assert.AreEqual((s1, s2, i1, i2), ("null string", "not null string", 0, 15));
    }
}
