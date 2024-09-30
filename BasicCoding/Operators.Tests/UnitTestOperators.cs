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
}
