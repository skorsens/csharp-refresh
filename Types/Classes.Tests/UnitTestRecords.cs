namespace Classes.Tests;


[TestClass]
public class UnitTestRecords
{
    [TestMethod]
    public void TestPerson_Properties()
    {
        Person p1 = new("n1", "sn1");
        var p2 = new Person("n2", "sn2");

        Assert.AreEqual("n1", p1.Name);
        Assert.AreEqual("sn1", p1.Surname);
        Assert.AreEqual("n2", p2.Name);
        Assert.AreEqual("sn2", p2.Surname);
    }

    [TestMethod]
    public void TestPerson_With()
    {
        Person p1 = new("n1", "sn1");
        var p2 = p1 with {
            Name="n2",
        };
        Assert.AreEqual("n2", p2.Name);
        Assert.AreEqual("sn1", p2.Surname);
        Assert.AreEqual(p1.Surname, p2.Surname);
        Assert.AreNotEqual(p1.Name, p2.Name);
    }

    [TestMethod]
    public void Test_MutableFieldsRecord()
    {
        var r1 = new MutableFieldsRecord(1,2);

        Assert.AreEqual(1, r1.F1);
        Assert.AreEqual(2, r1.F2);

        r1.F1 = 3;
        r1.F2++;

        Assert.AreEqual(3, r1.F1);
        Assert.AreEqual(3, r1.F2);
    }

    [TestMethod]
    public void TestRecordClass()
    {
        RecordClassPerson p1 = new("n1", "sn1");
        RecordClassPerson p2 = new("n2", "sn2");
        RecordClassPerson p3 = p1;

        Assert.AreEqual("n1", p1.Name);
        Assert.AreEqual("sn1", p1.Surname);
        Assert.AreEqual("n2", p2.Name);
        Assert.AreEqual("sn2", p2.Surname);
        Assert.AreEqual(p1, p3);
        Assert.IsFalse(object.ReferenceEquals(p1,p2));
    }
}
