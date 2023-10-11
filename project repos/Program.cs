using System.Threading.Channels;
using System.Transactions;
using project_repos;

bool quit = true;
/*
 * options:
 * change farmer1
 * addplant (choose plant)2
 * find plant3
 * delete plant4
 * show storage5
 * show plants6
 * quit7
 */

Console.WriteLine("Enter farmer first name, last name, specialization");
Farmer farmer = new Farmer(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

Console.WriteLine("Enter farm name, plantslimit");
Farm farm = new Farm(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), farmer);

while (quit == true)
{
    Console.WriteLine("Change farmer[1]\nAdd plant[2]\nFind plant by name[3]\nDelete plant[4]\nShow storage[5]\nShowPlants[6]\nQuit[7]");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 1)
    {
        Console.WriteLine("Enter farmer first name, last name, specialization");
        Farmer newFarmer = new Farmer(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        farm.ChangeFarmer(newFarmer);
    }
    else if (input == 2)
    {
        Console.WriteLine("Choose plant type: Potato[1], Carrot[2], CommonPlant[3]");
        int plantInput = Convert.ToInt32(Console.ReadLine());
        if (plantInput == 1)
        {
            Console.WriteLine("Enter potato name, full name, growing time, is need to regrow, weigth, is fertilized");
            farm.AddPlant(new Potato(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()),
                Convert.ToBoolean(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),
                Convert.ToBoolean(Console.ReadLine())));
        }
        else if (plantInput == 2)
        {
            Console.WriteLine("Enter carrot name, full name, growing time, is need to regrow");
            farm.AddPlant(new Carrot(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()),
                            Convert.ToBoolean(Console.ReadLine())));
        }
        else if (plantInput == 3)
        {
            Console.WriteLine("Enter carrot name, full name, growing time, is need to regrow");
            farm.AddPlant(new Carrot(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()),
                            Convert.ToBoolean(Console.ReadLine())));
        }
    }
    else if (input == 3)
    {
        Console.WriteLine(farm.FindByPlantName(Console.ReadLine()));
    } 
    else if (input == 4)
    {
        Console.WriteLine("Enter plant name");
        farm.DeletePlant(farm.FindByPlantName(Console.ReadLine()));
    } 
    else if (input == 5)
    {
        farm.PrintStorage();
    } 
    else if (input == 6)
    {
        farm.PrintPlants();
    } 
    else if (input == 7)
    {
        quit = false;
    }
    
}
