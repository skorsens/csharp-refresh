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
}