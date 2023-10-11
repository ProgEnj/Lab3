namespace project_repos;

public class Carrot : Plant
{
    public int Length;
    
    public Carrot(string shortName, string fullName, int growingTime, bool isNeedReGrow) 
        : base(shortName, fullName, growingTime, isNeedReGrow)
    {
        Length = new Random().Next(7, 15);
    }

    public override Harvest Yield()
    {
        if (Length >= 10)
        {
            return new Harvest(1, FullName + " (Long)");
        }
        else
        {
            return new Harvest(1, FullName + " (Short)");
        }
    }
}