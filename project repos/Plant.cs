using System.Runtime.CompilerServices;

namespace project_repos;

public delegate void PlantHandler(object sender, PlantGrownEventArgs e);

public abstract class Plant
{
    public event PlantHandler PlantGrown;
    private Timer _timer;

    public string ShortName { get; }
    public string FullName { get; }
    public int GrowingTime { get; }
    public bool IsNeedReGrow { get; }

    protected Plant(string shortName, string fullName, int growingTime, bool isNeedReGrow)
    {
        ShortName = shortName;
        FullName = fullName;
        GrowingTime = growingTime;
        IsNeedReGrow = isNeedReGrow;
    }

    public void StartTimer(Farm farm)
    {
        TimerCallback tm = new TimerCallback(OnPlantGrown);
        var info = new PlantGrownEventArgs(this, farm);
        _timer = new Timer(tm, info, 0, GrowingTime);
    }

    public virtual void OnPlantGrown(object e)
    {
        PlantGrown?.Invoke(this, (PlantGrownEventArgs)e);
        if (!IsNeedReGrow)
        {
            _timer.Dispose();
        }
    }

    public virtual Harvest Yield()
    {
        return new Harvest(1, FullName);
    }
};