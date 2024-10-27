namespace Classes.Tests;

[TestClass]
public class UnitTestCounter
{
    [TestMethod]
    public void TestCounter_GetNextValue()
    {
        Counter counter = new(0);

        Assert.AreEqual(0, counter.GetNext());
        Assert.AreEqual(1, counter.GetNext());
        Assert.AreEqual(2, counter.GetNext());
    }

    [TestMethod]
    public void TestCounter_TotalCount()
    {
        Counter c1 = new(1);
        var c2 = new Counter(2);

        Counter.ResetTotalCnt();
        
        Assert.AreEqual(0, Counter.TotalCnt);
        Assert.AreEqual(1, c1.GetNext());
        Assert.AreEqual(2, c2.GetNext());
        Assert.AreEqual(2, Counter.TotalCnt);
        
        Assert.AreEqual(2, c1.GetNext());
        Assert.AreEqual(3, c1.GetNext());
        Assert.AreEqual(4, Counter.TotalCnt);
    } 
}
