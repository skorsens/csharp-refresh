namespace Classes.Tests;


[TestClass]
public class UnitTestConstructors
{
    [TestMethod]
    public void TestClassWithExplicitConstructor()
    {
        var i1 = new ClassWithExplicitConstructor(1.0, 2);

        Assert.AreEqual(1.0, i1.F1);
        Assert.AreEqual(2, i1.F2);
    }

    [TestMethod]
    public void TestClassWithPrimaryConstructor()
    {
        var i1 = new ClassWithPrimaryConstructor(1.0, 2);

        Assert.AreEqual(1.0, i1.F1);
        Assert.AreEqual(2, i1.F2);

        i1.F1 = 2.0;
        i1.F2 = 3;

        Assert.AreEqual(2.0, i1.F1);
        Assert.AreEqual(3, i1.F2);
    }

    [TestMethod]
    public void TestRecordClassWithCopyConstructor()
    {
        RecordClassWithCopyConstructor r1 = new(1,2);
        RecordClassWithCopyConstructor r2 = new(r1);
        RecordClassWithCopyConstructor r3 = r1;

        Assert.AreEqual(r1, r2);
        Assert.AreEqual(r1, r3);
        Assert.IsFalse(object.ReferenceEquals(r1, r2));
        Assert.IsTrue(object.ReferenceEquals(r1, r3));
    }

    [TestMethod]
    public void TestClassWithCopyConstructor()
    {
        ClassWithCopyConstructor c1 = new(1, 2);
        ClassWithCopyConstructor c2 = new(c1);
        ClassWithCopyConstructor c3 = c1;

        Assert.AreNotEqual(c1, c2);
        Assert.AreEqual(c1, c3);
        Assert.IsTrue(object.ReferenceEquals(c1, c3));
        Assert.IsFalse(object.ReferenceEquals(c1, c2));
    }

    [TestMethod]
    public void TestClassWithChainedConstructors()
    {
        ClassWithChainedConstructors c1 = new ClassWithChainedConstructors(1,2);
        ClassWithChainedConstructors c2 = new ClassWithChainedConstructors(1);
        ClassWithChainedConstructors c3 = new ClassWithChainedConstructors();

        Assert.AreEqual(1, c1.F1);
        Assert.AreEqual(2, c1.F2);
        Assert.AreEqual(1, c2.F1);
        Assert.AreEqual(-1, c2.F2);
        Assert.AreEqual(-1, c3.F1);
        Assert.AreEqual(-2, c3.F2);
    }

    [TestMethod]
    public void TestClassWithStaticConstructor()
    {
        Assert.AreEqual(1, ClassWithStaticConstructor.F1);
        Assert.AreEqual(0, ClassWithStaticConstructor.F2);
    }
}
