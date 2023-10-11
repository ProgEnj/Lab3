namespace project_repos;

public class Potato : Plant
{
    public int Weight { get; }
    public bool isFertilized;

    public Potato(string shortName, string fullName, int growingTime, bool isNeedReGrow, int weight, bool isFertilized) 
        : base(shortName, fullName, growingTime, isNeedReGrow)
    {
        Weight = weight;
        this.isFertilized = isFertilized;
    }

    public override Harvest Yield()
    {
        if (isFertilized)
        {
            return new Harvest(4, FullName);
        }
        else
        {
            return new Harvest(1, FullName);
        }
    }
}
