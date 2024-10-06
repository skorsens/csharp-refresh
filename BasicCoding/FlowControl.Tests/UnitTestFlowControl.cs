using System.Security.Cryptography;

namespace FlowControl.Tests;

[TestClass]
public class UnitTestFlowControl
{
    [TestMethod]
    public void TestIfStatement()
    {
        var (r1, r2, r3) = FlowControl.IfStatement();

        Assert.AreEqual((r1, r2, r3), (true, true, true));
    }

    [TestMethod]
    public void TestSwitchStatement()
    {
        var r1 = FlowControl.SwitchStatement();

        Assert.AreEqual(r1, 5);
    }

    [TestMethod]
    public void TestPatterns_Declaration()
    {
        Assert.AreEqual(FlowControl.Patterns_Declaration("1"), 1);
        Assert.AreEqual(FlowControl.Patterns_Declaration(2), 2);
        Assert.AreEqual(FlowControl.Patterns_Declaration(2.5), 0);
    }

    [TestMethod]
    public void TestPatterns_Positional()
    {
        Assert.AreEqual(1, FlowControl.Patterns_Positional((1,1)));
        Assert.AreEqual(2, FlowControl.Patterns_Positional((2,2)));
        Assert.AreEqual(0, FlowControl.Patterns_Positional((1,2)));
    }

    [TestMethod]
    public void TestPatterns_List()
    {
        Assert.AreEqual(1, FlowControl.Patterns_List([1,2,3,6]));
        Assert.AreEqual(3, FlowControl.Patterns_List([2,3,4,7]));
        Assert.AreEqual(0, FlowControl.Patterns_List([3,3,4,7]));
    }

    [TestMethod]
    public void TestPatterns_Property()
    {
        Assert.AreEqual(1, FlowControl.Patterns_Property("1"));
        Assert.AreEqual(2, FlowControl.Patterns_Property("12"));
        Assert.AreEqual(3, FlowControl.Patterns_Property("123"));
        Assert.AreEqual(0, FlowControl.Patterns_Property("1234"));
    }

    [TestMethod]
    public void TestPatterns_Relational()
    {
        Assert.AreEqual(1, FlowControl.Patterns_Relational(2));
        Assert.AreEqual(2, FlowControl.Patterns_Relational(3));
        Assert.AreEqual(0, FlowControl.Patterns_Relational(-1));
    }

    [TestMethod]
    public void TestPatterns_When()
    {
        Assert.AreEqual(1, FlowControl.Patterns_When((3,2)));
        Assert.AreEqual(0, FlowControl.Patterns_When((2,3)));
        Assert.AreEqual(0, FlowControl.Patterns_When((2,3,4)));
        Assert.AreEqual(0, FlowControl.Patterns_When(3));
        Assert.AreEqual(0, FlowControl.Patterns_When(("s1", "s2")));
    }

    [TestMethod]
    public void TestPatterns_SwitchStatement()
    {
        Assert.AreEqual(1, FlowControl.Patterns_SwitchStatement(2));
        Assert.AreEqual(2, FlowControl.Patterns_SwitchStatement(3));
        Assert.AreEqual(0, FlowControl.Patterns_SwitchStatement(-1));
    }
}
