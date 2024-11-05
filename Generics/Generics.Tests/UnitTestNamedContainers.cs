namespace Generics.Tests;

[TestClass]
public class UnitTestNamedContainers
{
    [TestMethod]
    public void TestNamedContainersClass()
    {
        NamedContainersClass<int> c = new(2, "named container 2");

        Assert.AreEqual(2, c.Item);
        Assert.AreEqual("named container 2", c.Name);
    }

/*
    [TestMethod]
    public void TestNamedContainersRecord()
    {
        TestNamedContainersRecord<int> c = new(2, "named container 2");

        Assert.AreEqual(2, c.Item);
        Assert.AreEqual("named container 2", c.Name);
    }
*/
}