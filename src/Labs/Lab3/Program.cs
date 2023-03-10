using Core;

var students = new[]
{
    new Student("Иван Иванов", 20, "Информационные системы"),
    new Student("Петр Петров", 21, "Информационные системы"),
};

WriteToConsole("Students:", students);

var teachers = new[]
{
    new Teacher("Сергей Протасов",30, 130),
    new Teacher("Дмитрий Эникеев",  31, 100),
};

WriteToConsole("Teachers:", teachers);

var departmentHeads = new[]
{
    new DepartmentHead("Александр Кузнецов", 40,  "Информационные системы"),
    new DepartmentHead("Алексей Кузнецов",41,  "Информационные системы")
};

WriteToConsole("Department heads:", departmentHeads);

Console.ReadKey();

void WriteToConsole(string title, Person[] persons)
{
    Console.WriteLine(title);
    
    foreach (var person in persons) 
        Console.WriteLine(person);
    
    Console.WriteLine();
}