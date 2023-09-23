namespace project_repos;

public class Farm
{
    public List<Plant> PlantsOnGrowing { get; }
    public Farmer? Farmer { get; private set; }

    private int _plantsLimit;
    public string Name { get; set; }
    public int PlantsLimit => _plantsLimit;

    public Farm(string name, int limit, Farmer? farmer)
    {
        _plantsLimit = limit;
        PlantsOnGrowing = new List<Plant>(20);
        Farmer = farmer;
    }
    
    public Farm(string name, int limit) : this(name, limit, null)
    {}
    
    public Farm(string name) : this(name, 20)
    {}
    
    public Farm() : this("Farm")
    {}
    
    

}