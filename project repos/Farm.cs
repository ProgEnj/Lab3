namespace project_repos;

public class Farm
{
    public List<Plant> PlantsOnGrowing { get; }
    public Farmer? Farmer { get; private set; }
    public List<Harvest> Storage;

    private int _plantsLimit;
    public int PlantsLimit => _plantsLimit;
    private string _name;
    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length <= 0)
            {
                throw new Exception("Lenght of name <= 0");
            }
            else if (value.Length > 15)
            {
                throw new Exception("Length of name exceeds 15 characters");
            }
            else { _name = value; }
        }
    }
    
    public Farm(string name, int limit, Farmer? farmer)
    {
        Name = name;
        _plantsLimit = limit;
        PlantsOnGrowing = new List<Plant>(limit);
        Storage = new List<Harvest>();
        Farmer = farmer;
    }
    
    public Farm(string name, int limit) : this(name, limit, null) {}
    
    public Farm(string name) : this(name, 20) {}
    
    public Farm() : this("Farm") {}
    
    public bool AddPlant(Plant plant)
    {
        if (PlantsOnGrowing.Count == PlantsLimit)
        {
            return false;
        }
        PlantsOnGrowing.Add(plant);
        plant.PlantGrown += Farmer.CollectHarvest;
        plant.StartTimer(this);
        return true;
    }
    
    public bool DeletePlant(Plant plant)
    {
        return PlantsOnGrowing.Remove(plant);
        plant.PlantGrown -= Farmer.CollectHarvest;
    }
    
    public Plant? FindByPlantName(string name)
    {
        return PlantsOnGrowing.Find(x => name == x.FullName || name == x.ShortName);
    }

    public void AddFarmer(Farmer? farmer)
    {
        Farmer = farmer;
    }

    public void ChangeFarmer(Farmer? newFarmer)
    {
        if (PlantsOnGrowing.Count() == 0)
        {
            foreach (var plant in PlantsOnGrowing)
            {
                plant.PlantGrown -= Farmer.CollectHarvest;
                plant.PlantGrown += newFarmer.CollectHarvest;
            }
        }
    }

    public void PrintPlants()
    {
        foreach (var plant in PlantsOnGrowing)
        {
            Console.WriteLine(plant.FullName);
        }
    }

    public void PrintStorage()
    {
        foreach (var item in Storage)
        {
            Console.WriteLine(item.type + Storage.IndexOf(item));
        }
    }
}