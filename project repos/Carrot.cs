namespace project_repos;

public record Carrot : Plant
{
    public int Length { get; }
    
    public Carrot(string shortName, string fullName, int growingTime, bool isNeedGrow, int length) 
        : base(shortName, fullName, growingTime, isNeedGrow)
    {
        Length = length;
    }
}