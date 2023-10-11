namespace project_repos;

public class Harvest
{
    public int Amount { get; set; }
    public readonly string type;

    public Harvest(int amount, string type)
    {
        Amount = amount;
        this.type = type;
    }
}