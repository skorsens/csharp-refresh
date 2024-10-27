namespace Classes;


public class Counter(int _cnt)
{
    public int GetNext()
    {
        TotalCnt++;
        return _cnt++;
    }

    public static int TotalCnt { get; private set; } = 0;

    public static void ResetTotalCnt() => TotalCnt = 0;
}
