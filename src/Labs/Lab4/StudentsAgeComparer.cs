using System.Collections;
using Core;

namespace Lab4;

public class StudentsByAgeComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Student student1 && y is Student student2)
            return student1.Age.CompareTo(student2.Age);

        return 0;
    }
}