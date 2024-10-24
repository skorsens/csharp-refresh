using System.Security.Cryptography;

namespace Classes.Tests;


[TestClass]
public class UnitTestMethods
{
    [TestMethod]
    public void TestMethodWithOutParameter()
    {
        int r1 = ClassWithMethods.MethodWithOutParameter(1, out int rO1);

        Assert.AreEqual((2, 3), (r1, rO1));

        int rO2;
        int r2 = ClassWithMethods.MethodWithOutParameter(2, out rO2);

        Assert.AreEqual((3, 4), (r2, rO2));

    }

    [TestMethod]
    public void TestMethodWithRefParameter()
    {
        int rR1 = 1;
        int r1 = ClassWithMethods.MethodWithUnAssignedRefParameter(1, ref rR1);

         Assert.AreEqual((2, 1), (r1, rR1));
       

        int rR2 = 2;
        int r2 = ClassWithMethods.MethodWithAssignedRefParameter(2, ref rR2);

        Assert.AreEqual((5, 3), (r2, rR2));
    }

    [TestMethod]
    public void TestMethodWithInParameter()
    {
        int i1 = 1;

        int r1 = ClassWithMethods.MethodWithInParameter(in i1);
        int r2 = ClassWithMethods.MethodWithInParameter(i1);
        int r3 = ClassWithMethods.MethodWithInParameter(1);

        Assert.AreEqual(1, i1);
        Assert.AreEqual(3, r1);
        Assert.AreEqual(3, r2);
        Assert.AreEqual(3, r3);
    }

    [TestMethod]
    public void TestMethodWithRefReadonlyParameter()
    {
        int i1 = 1;
        int r1 = ClassWithMethods.MethodWithRefReadonlyParameter(ref i1);

        Assert.AreEqual(1, i1);
        Assert.AreEqual(3, r1);
    }

    [TestMethod]
    public void TestMethodWithRefReferenceParameter()
    {
        Counter c = new(0);
        Counter c1 = c;

        Assert.IsTrue(object.ReferenceEquals(c, c1));

        int r1 = ClassWithMethods.MethodWithRefReferenceParameter(ref c);

        Assert.IsFalse(object.ReferenceEquals(c, c1));
        Assert.AreEqual(0, r1);
        Assert.AreEqual(1, c1.GetNext());
        Assert.AreEqual(1, c.GetNext());
    }

    [TestMethod]
    public void TestMethodWithOutReferenceParameter()
    {
        Counter c;

        int r1 = ClassWithMethods.MethodWithOutReferenceParameter(out c);
        Assert.AreEqual(0, r1);
        Assert.AreEqual(1, c.GetNext());
    }

    [TestMethod]
    public void TestMethodWithOptionalParameters()
    {
        int r1 = ClassWithMethods.MethodWithOptionalParameters();
        int r2 = ClassWithMethods.MethodWithOptionalParameters(2);
        int r3 = ClassWithMethods.MethodWithOptionalParameters(i2: 4);
        int r4 = ClassWithMethods.MethodWithOptionalParameters(3, 4);

        Assert.AreEqual(3, r1);
        Assert.AreEqual(4, r2);
        Assert.AreEqual(5, r3);
        Assert.AreEqual(7, r4);
    }

    [TestMethod]
    public void TestMethodOverloaded()
    {
        int r1 = ClassWithMethods.MethodOverloaded();
        int r2 = ClassWithMethods.MethodOverloaded(2);

        Assert.AreEqual(1, r1);
        Assert.AreEqual(2, r2);
    }

    [TestMethod]
    public void TestMethodWithVariableArgumentsCount()
    {
        int r1 = ClassWithMethods.MethodWithVariableArgumentsCount(1);
        int r2 = ClassWithMethods.MethodWithVariableArgumentsCount(1, 2);
        int r3 = ClassWithMethods.MethodWithVariableArgumentsCount(1, 2, 3);
        
        Assert.AreEqual(1, r1);
        Assert.AreEqual(3, r2);
        Assert.AreEqual(6, r3);
    }

    [TestMethod]
    public void TestMethodExtension()
    {
        int i1 = 1;
        int i2 = i1.MethodExtension();

        Assert.AreEqual(2, i2);
    }
}
