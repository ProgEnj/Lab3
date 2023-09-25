namespace project_repos;

public class Farmer
{
    private string firstName;
    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (value.Length > 15)
            {
                throw new Exception("Length exceeds 15 characters");
            }
            else
            { firstName = value; }
        }
    }
    private string lastName;
    public string LastName
    {
        get { return lastName; }
        set
        {
            if (value.Length > 15)
            {
                throw new Exception("Length exceeds 15 characters");
            }
            else
            { lastName = value; }
        }
    }
    public string Specialization { get; set; }

    public Farmer(string firstName, string lastName, string specialization)
    {
        FirstName = firstName;
        LastName = lastName;
        Specialization = specialization;
    }
}