namespace Types.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestTuples()
    {
        var points = Types.Tuples();
        Assert.AreEqual(points.p1.X, 1);
        Assert.AreEqual(points.p1.Y, 2);
        Assert.AreEqual(points.p2.X, 3);
        Assert.AreEqual(points.p2.Y, 4);
        Assert.AreEqual(points.p3.X, 5);
        Assert.AreEqual(points.p3.Y, 6);
        Assert.AreEqual(points.p1, (1, 2));
        Assert.AreEqual(points, ((1,2), (3,4), (5,6)));
    }

    [TestMethod]
    public void TestDynamic()
    {
        Assert.AreEqual(Types.Dynamic(), "d1");
    }

    [TestMethod]
    public void TestObject()
    {
        Assert.AreEqual(Types.Object(), "o1");
    }
}
