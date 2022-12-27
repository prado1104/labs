namespace Lab3;

public class Student : Person
{
    public Student(string firstName, string lastName, int age, string id, string major) : base(firstName, lastName, age, id)
    {
        Major = major;
    }

    public string Major { get; }

    public override string ToString()
    {
        return $"{base.ToString()}, {Major}";
    }
}