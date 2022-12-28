namespace Core;

public class DepartmentHead : Person, IComparable
{
    public DepartmentHead(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }

    public string Department { get; }
    
    public override string ToString()
    {
        return $"{base.ToString()}, {Department}";
    }

    public int CompareTo(object? obj)
    {
        if (obj is DepartmentHead otherDepartmentHead)
            return string.Compare(Department, otherDepartmentHead.Department, StringComparison.Ordinal);
        
        throw new ArgumentException("Object is not a DepartmentHead");
    }
}