namespace Classes.Tests;


[TestClass]
public class UnitTestsOperators
{
    [TestMethod]
    public void TestOperatorAdd()
    {
        ClassWithOperators c1 = new(1);
        ClassWithOperators c2 = new(2);
        ClassWithOperators c3 = c1 + c2;
        ClassWithOperators c4 = c1 + 2;

        Assert.AreEqual(3, (int)c3);
        Assert.AreEqual(3, (int)c4);
    }

    [TestMethod]
    public void TestOperatorCompare()
    {
        ClassWithOperators c1 = new(1);
        ClassWithOperators c2 = new(2);

        Assert.IsTrue(c1 < c2);
        Assert.IsTrue(c2 > c1);
        Assert.IsFalse(c1 > c2);
    }

    [TestMethod]
    public void TestOperatorTrueFalse()
    {
        ClassWithOperators c1 = new(5); // !true && !false
        ClassWithOperators c2 = new(6); // true
        ClassWithOperators c3 = new(4); // false

        int i1 = 1;
        int i2 = 1;

        if (c2)
            i1 = 2;

        if (c3)
            i2 = 2;

        Assert.AreEqual(2, i1);
        Assert.AreEqual(1, i2);
    }
}
