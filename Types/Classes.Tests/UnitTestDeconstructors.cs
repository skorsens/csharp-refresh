namespace Classes.Tests;


[TestClass]
public class UnitTestDeconstructors
{
    [TestMethod]
    public void TestSizeDeconstructor()
    {
        Size s = new(1.0, 2.0);
        (double w, double h) = s;

        Assert.AreEqual(1.0, w);
        Assert.AreEqual(2.0, h);
    }

    [TestMethod]
    public void TestSize_DescribeSize()
    {
        Size s1 = new(0, 0);
        Size s2 = new(0, 1);
        Size s3 = new(1, 0);
        Size s4 = new(1, 2);

        Assert.AreEqual("Empty", Size.DescribeSize(s1));
        Assert.AreEqual("Narrow", Size.DescribeSize(s2));
        Assert.AreEqual("Low 1", Size.DescribeSize(s3));
        Assert.AreEqual("Normal", Size.DescribeSize(s4));
    }

    [TestMethod]
    public void TestSizeRecordClass_Deconstructor()
    {
        SizeRecordClass s = new(1, 2);
        (int w, int h) = s;

        Assert.AreEqual(1, s.W);
        Assert.AreEqual(2, s.H);
    }

    [TestMethod]
    public void TestSizeRecordStruct_Deconstructor()
    {
        SizeRecordStruct s = new(1, 2);
        (int w, int h) = s;

        Assert.AreEqual(1, s.W);
        Assert.AreEqual(2, s.H);
    }
}
