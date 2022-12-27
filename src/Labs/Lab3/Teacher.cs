using Lab3;

public class Teacher : Person
{
    public Teacher(string firstName, string lastName, int age, string id, int salary) : base(firstName, lastName, age, id)
    {
        Salary = salary;
    }

    public int Salary { get; }

    public override string ToString()
    {
        return $"{base.ToString()}, {Salary}";
    }
}