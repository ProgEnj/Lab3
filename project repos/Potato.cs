namespace project_repos;

public record Potato : Plant
{
    public int Weight { get; }

    public Potato(string shortName, string fullName, int growingTime, bool isNeedGrow, int weight) 
        : base(shortName, fullName, growingTime, isNeedGrow)
    {
        Weight = weight;
    }
}
