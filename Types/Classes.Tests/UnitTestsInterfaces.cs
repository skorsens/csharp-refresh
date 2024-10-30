namespace Classes.Tests;


[TestClass]
public class UnitTestsInterfaces
{
    [TestMethod]
    public void TestIIfc1()
    {
        CIfc c = new();

        Assert.AreEqual("0", c.AMethod(0));
        Assert.AreEqual("1", c.AMethod(1));
        Assert.AreEqual("APropertyWithDfltImplementation", ((IIfc)new CIfc()).APropertyWithDfltImplementation);
    }
}
