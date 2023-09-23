namespace project_repos;

public class Plant
{
    public string ShortName { get; }
    public string FullName { get; }
    public int GrowingTime { get; }
    public bool IsNeedRegrow { get; }

    private Plant(string shortName, string fullName, int growingTime, bool isNeedRegrow)
    {
        ShortName = shortName;
        FullName = fullName;
        GrowingTime = growingTime;
        IsNeedRegrow = isNeedRegrow;
    }
}