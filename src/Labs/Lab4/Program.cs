using Core;
using Lab4;

var students = new[]
{
    new Student("Петр Петров", 18, "Информационные системы"),
    new Student("Иван Иванов", 21, "Информационные системы"),
};

Array.Sort(students);
WriteToConsole("Students (sorted by name):", students);

Array.Sort(students, new StudentsByAgeComparer());
WriteToConsole("Students (sorted by age):", students);


var teachers = new[]
{
    new Teacher("Дмитрий Эникеев",  31, 140),
    new Teacher("Сергей Протасов",30, 160),
};

Array.Sort(teachers);
WriteToConsole("Teachers (sorted by age):", teachers);

Array.Sort(teachers, new TeachersBySalaryComparer());
WriteToConsole("Teachers (sorted by salary):", teachers);


var departmentHeads = new[]
{
    new DepartmentHead("Александр Кузнецов", 40,  "Менеджмент"),
    new DepartmentHead("Алексей Кузнецов",41,  "Информационные системы")
};

Array.Sort(departmentHeads);
WriteToConsole("Department heads (sorted by department):", departmentHeads);

Array.Sort(departmentHeads, new DepartmentHeadsByNameComparer());
WriteToConsole("Department heads (sorted by name):", departmentHeads);

Console.ReadKey();

void WriteToConsole(string title, Person[] persons)
{
    Console.WriteLine(title);
    
    foreach (var person in persons) 
        Console.WriteLine(person);
    
    Console.WriteLine();
}