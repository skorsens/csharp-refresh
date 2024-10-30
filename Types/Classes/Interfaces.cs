namespace Classes;


public interface IIfc
{
    int this[int i] { get; set; }
    string AProperty {get; set; }
    string AMethod(int p);

    string APropertyWithDfltImplementation => "APropertyWithDfltImplementation";
}


public class CIfc : IIfc
{
    private int[] _i_for_indexer = [1,2,3,4];

    public int this[int i]
    {
        get => i < _i_for_indexer.Length ? _i_for_indexer[i] : -1;
        set
        {
            if (i < _i_for_indexer.Length)
                _i_for_indexer[i] = value;
        }
    }

    public string AProperty {get; set; } = "APropertyInitVal";

    public string AMethod(int p)
    {
        return p switch {
            0 => "0",
            1 => "1",
            _ => "unknown",
        };
    }
}