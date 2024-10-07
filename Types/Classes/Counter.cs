namespace Classes;


public class Counter(int _cnt)
{
    private static int _totalCnt = 0;

    public int GetNext()
    {
        _totalCnt++;
        return _cnt++;
    }

    public static int TotalCnt => _totalCnt;
}
