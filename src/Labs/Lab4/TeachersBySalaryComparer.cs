using System.Collections;
using Core;

namespace Lab4;

public class TeachersBySalaryComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Teacher teacher1 && y is Teacher teacher2)
            return teacher1.Salary.CompareTo(teacher2.Salary);

        return 0;
    }
}