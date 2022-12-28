namespace Core;

public class Teacher : Person, IComparable
{
    public Teacher(string name, int age, int salary) : base(name, age)
    {
        Salary = salary;
    }

    public int Salary { get; }

    public override string ToString()
    {
        return $"{base.ToString()}, {Salary}";
    }

    public int CompareTo(object? obj)
    {
        if (obj is Teacher other)
            return Salary.CompareTo(other.Salary);

        throw new ArgumentException("Object is not a Teacher");
    }
}