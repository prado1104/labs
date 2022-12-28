using Core;

var students = new[]
{
    new Student("Петр Петров", 21, "Информационные системы"),
    new Student("Иван Иванов", 20, "Информационные системы"),
};

Array.Sort(students);
WriteToConsole("Students:", students);

var teachers = new[]
{
    new Teacher("Дмитрий Эникеев",  31, 100),
    new Teacher("Сергей Протасов",30, 130),
};
Array.Sort(teachers);
WriteToConsole("Teachers:", teachers);

var departmentHeads = new[]
{
    new DepartmentHead("Александр Кузнецов", 40,  "Менеджмент"),
    new DepartmentHead("Алексей Кузнецов",41,  "Информационные системы")
};
Array.Sort(departmentHeads);
WriteToConsole("Department heads:", departmentHeads);

Console.ReadKey();

void WriteToConsole(string title, Person[] persons)
{
    Console.WriteLine(title);
    
    foreach (var person in persons) 
        Console.WriteLine(person);
    
    Console.WriteLine();
}