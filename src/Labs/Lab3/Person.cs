namespace Lab3;

public abstract class Person
{
    public Person(string firstName, string lastName, int age, string id)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Id = id;
    }
    
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }
    public string Id { get; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Age})";
    }
}