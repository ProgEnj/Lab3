namespace project_repos;

public class Farm
{
    public List<Plant> PlantsOnGrowing { get; }
    public Farmer? Farmer { get; private set; }

    private int _plantsLimit;
    public int PlantsLimit => _plantsLimit;
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length > 15)
            {
                throw new Exception("Length exceeds 30 characters");
            }
            else { name = value; }
        }
    }
    
    public Farm(string name, int limit, Farmer? farmer)
    {
        Name = name;
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
    
    public bool AddPlant(Plant plant)
    {
        if (PlantsOnGrowing.Count == PlantsLimit)
        {
            return false;
        }
        PlantsOnGrowing.Add(plant);
        return true;
    }
    
    public bool DeletePlant(Plant plant)
    {
        return PlantsOnGrowing.Remove(plant);
    }
    
    public Plant? FindByPlantName(string name)
    {
        return PlantsOnGrowing.Find(x => name == x.FullName || name == x.ShortName);
    }

    public void AddFarmer(Farmer? farmer)
    {
        Farmer = farmer;
    }

}