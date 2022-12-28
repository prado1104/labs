namespace Core;

public class Student : Person, IComparable
{
    public Student(string name, int age, string major) : base(name, age)
    {
        Major = major;
    }

    public string Major { get; }

    public override string ToString()
    {
        return $"{base.ToString()}, {Major}";
    }

    public int CompareTo(object? obj)
    {
        if (obj is Student otherStudent)
            return Name.CompareTo(otherStudent.Name);
        
        throw new ArgumentException("Object is not a Student");
    }
}