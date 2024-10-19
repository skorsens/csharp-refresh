namespace Classes.Tests;


[TestClass]
public class UnitTestStructs
{
    [TestMethod]
    public void TestPoint_PrimaryConstructor()
    {
        Point p1 = new();
        Point p2 = new(1.0, 2.0);
         
        Assert.AreEqual(0.0, p1.X, 1E-14);
        Assert.AreEqual(0.0, p1.Y, 1E-14);
        Assert.AreEqual(1.0, p2.X, 1E-14);
        Assert.AreEqual(2.0, p2.Y, 1E-14);
    }

    [TestMethod]
    public void TestPoint_EqualsPoint()
    {
        var p1 = new Point(1.0, 2.0);
        var p2 = new Point(1.0, 2.0);
        var p3 = new Point(2.0, 3.0);

        Assert.AreEqual(true, p1.Equals(p2));
        Assert.AreEqual(false, p1.Equals(p3));
    }

    [TestMethod]
    public void TestPoint_EqualsObject()
    {
        var p1 = new Point(1.0, 2.0);
        var p2 = new Point(1.0, 2.0);
        var p3 = new Point(2.0, 3.0);
        int i = 3;

        Assert.AreEqual(true, p1.Equals(p2));
        Assert.AreEqual(false, p1.Equals(p3));
        Assert.AreEqual(false, p1.Equals(i));
    }

    [TestMethod]
    public void TestPoint_OperatorEquals()
    {
        var p1 = new Point(1.0, 2.0);
        var p2 = new Point(1.0, 2.0);
        var p3 = new Point(2.0, 3.0);

        Assert.AreEqual(true, p1 == p2);
        Assert.AreEqual(false, p1 == p3);
        Assert.AreEqual(false, p1 != p2);
        Assert.AreEqual(true, p1 != p3);
    }

    [TestMethod]
    public void TestPoint_ReferenceEquals()
    {
        var p1 = new Point(1.0, 2.0);
        var p2 = p1;
        var p3 = new Point(2.0, 3.0);
        int i1 = 1;
        int i2 = i1;
        var c1 = new Counter(0);
        var c2 = c1;
        var r1 = new Person("n", "sn");
        var r2 = r1;

        Assert.AreEqual(false, object.ReferenceEquals(i1, i2));
        Assert.AreEqual(false, object.ReferenceEquals(p1, p2));
        Assert.AreEqual(false, object.ReferenceEquals(p1, p3));
        Assert.AreEqual(false, object.ReferenceEquals(p1, p1));
        Assert.AreEqual(true, object.ReferenceEquals(c1, c2));
        Assert.AreEqual(true, object.ReferenceEquals(c1, c1));
        Assert.AreEqual(true, object.ReferenceEquals(r1, r2));
        Assert.AreEqual(true, object.ReferenceEquals(r1, r1));
    }

    [TestMethod]
    void TestRecordPoint()
    {
        var p11 = new RecordPoint(1.0, 2.0);
        var p12 = new RecordPoint(1.0, 2.0);
        var p21 = new RecordPoint(2.0, 3.0);

        Assert.AreEqual(p11, p12);
        Assert.AreNotEqual(p11, p21);
    }
 }
