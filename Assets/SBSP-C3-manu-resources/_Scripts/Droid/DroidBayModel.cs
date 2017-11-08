public class DroidBayModel
{
    private int _bayIndex;
    private Droid _currentDroid;

    public int GetBayIndex()
    {
        return _bayIndex;
    }

    public void SetBayIndex(int value)
    {
        _bayIndex = value;
    }

    public Droid GetDroid()
    {
        return _currentDroid;
    }

    public void SetDroid(Droid droid)
    {
        _currentDroid = droid;
    }
}
