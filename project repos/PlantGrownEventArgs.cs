namespace project_repos;

public class PlantGrownEventArgs : EventArgs
{
    public Plant Plant { get; }
    public Farm Farm { get; }

    public PlantGrownEventArgs(Plant plant, Farm farm)
    {
        Plant = plant;
        Farm = farm;
    }
}