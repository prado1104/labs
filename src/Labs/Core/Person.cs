namespace Core;

public abstract class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public string Name { get; }
    public int Age { get; }

    public override string ToString()
    {
        return $"{Name} ({Age})";
    }
}