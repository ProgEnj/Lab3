namespace project_repos;

public abstract record Plant
{
    public string ShortName { get; }
    public string FullName { get; }
    public int GrowingTime { get; }
    public bool IsNeedGrow { get; }
    
    protected Plant(string shortName, string fullName, int growingTime, bool isNeedGrow)
    {
        ShortName = shortName;
        FullName = fullName;
        GrowingTime = growingTime;
        IsNeedGrow = isNeedGrow;
    }
};