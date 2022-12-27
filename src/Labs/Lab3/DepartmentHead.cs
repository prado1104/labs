using Lab3;

public class DepartmentHead : Person
{
    public DepartmentHead(string firstName, string lastName, int age, string id, string department) : base(firstName, lastName, age, id)
    {
        Department = department;
    }

    public string Department { get; }
    
    public override string ToString()
    {
        return $"{base.ToString()}, {Department}";
    }
}