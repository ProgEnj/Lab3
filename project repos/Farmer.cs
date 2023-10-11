namespace project_repos;

public class Farmer
{
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (value.Length <= 0)
            {
                throw new Exception("Lenght of name <= 0");
            }
            else if (value.Length > 15)
            {
                throw new Exception("Length exceeds 15 characters");
            }
            else
            { _firstName = value; }
        }
    }
    private string _lastName;
    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (value.Length > 15)
            {
                throw new Exception("Length exceeds 15 characters");
            }
            else
            { _lastName = value; }
        }
    }
    
    public string Specialization { get; set; }

    public Farmer(string firstName, string lastName, string specialization)
    {
        FirstName = firstName;
        LastName = lastName;
        Specialization = specialization;
    }

    public void CollectHarvest(object sender, PlantGrownEventArgs e)
    {
        Farm farm = e.Farm;
        Plant plant = e.Plant;
        
        
        farm.Storage.Add(plant.Yield());
        if (plant.IsNeedReGrow)
        {
            plant.StartTimer(farm);
        }
        else
        {
            farm.DeletePlant(plant);
        }
    }
}