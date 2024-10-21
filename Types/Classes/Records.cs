using System.Runtime.InteropServices;

namespace Classes;

public record Person(string Name, string Surname);

public record MutableFieldsRecord(int F1, int F2)
{
    public int F1 { get; set; } = F1;
    public int F2 { get; set; } = F2;

    public int SumF1AndF2()
    {
        return F1 + F2;
    }
}


// `record class` is equivalent to `record`
public record class RecordClassPerson(string Name, string Surname);

