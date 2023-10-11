namespace project_repos;

public class CommonPlant : Plant
{
    public CommonPlant(string shortName, string fullName, int growingTime, bool isNeedReGrow) 
            : base(shortName, fullName, growingTime, isNeedReGrow) { }
}