namespace project_repos;

public class Farmer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialization { get; set; }

    public Farmer(string firstName, string lastName, string specialization)
    {
        FirstName = firstName;
        LastName = lastName;
        Specialization = specialization;
    }
}