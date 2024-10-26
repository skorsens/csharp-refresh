namespace Classes.Tests;

[TestClass]
public class UnitTestsProperties
{
    [TestMethod]
    public void TestProperties()
    {
        ClassWithProperties c = new();

        Assert.AreEqual(0, c.ExplicitProperty);

        c.ExplicitProperty = 1;
        Assert.AreEqual(1, c.ExplicitProperty);

        c.ExpressionExplicitProperty = 0;
        Assert.AreEqual(0, c.ExpressionExplicitProperty);

        Assert.AreEqual(0, c.AutoProperty);
        c.AutoProperty = 1;
        Assert.AreEqual(1, c.AutoProperty);
    }

    [TestMethod]
    public void TestRoProperty()
    {
        ClassWithProperties c1 = new();
        ClassWithProperties c2 = new(13);

        Assert.AreEqual(12, c1.RoProperty);
        Assert.AreEqual(13, c2.RoProperty);
    }

    [TestMethod]
    public void TestObjectInitializer()
    {
        ClassWithProperties c1 = new(){
            AutoProperty = 12,
        };
        ClassWithProperties c2 = new(13){
            AutoProperty = 12,
        };
        ClassWithProperties c3 = new(13);

        Assert.AreEqual(12, c1.RoProperty);
        Assert.AreEqual(12, c1.AutoProperty);
        Assert.AreEqual(13, c2.RoProperty);
        Assert.AreEqual(12, c2.AutoProperty);
        Assert.AreEqual(13, c3.RoProperty);
        Assert.AreEqual(0, c3.AutoProperty);
    }

    [TestMethod]
    public void TestRoPropertyWithInit()
    {
        ClassWithProperties c = new(13){
            RoPropertyWithInit = 14,
        };

        Assert.AreEqual(14, c.RoPropertyWithInit);
    }

    [TestMethod]
    public void TestRoStructWithInitProperty()
    {
        RoStructWithInitProperty s1 = new(1, 2);
        RoStructWithInitProperty s2 = s1 with {
            F2 = 3,
        };

        Assert.AreEqual(1, s1.F1);
        Assert.AreEqual(2, s1.F2);
        Assert.AreEqual(s1.F1, s2.F1);
        Assert.AreEqual(3, s2.F2);
    }

    [TestMethod]
    public void TestIndexerProperty()
    {
        ClassWithProperties c1 = new();

        Assert.AreEqual("one & 1", c1["one", 1]);
        Assert.AreEqual("two & 2", c1["two", 2]);
        Assert.AreEqual(0, c1[0]);
        Assert.AreEqual(1, c1[1]);
        Assert.AreEqual(2, c1[2]);
        Assert.AreEqual(109, c1[9]);

        c1[1] = 201;
        Assert.AreEqual(0, c1[0]);
        Assert.AreEqual(201, c1[1]);
        Assert.AreEqual(2, c1[2]);

        ClassWithProperties c2 = new()
        {
            [0] = 500,
            [1] = 501,
        };

        Assert.AreEqual(500, c2[0]);
        Assert.AreEqual(501, c2[1]);
        Assert.AreEqual(2, c2[2]);
    }
}
