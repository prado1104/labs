using System.Collections;
using Core;

namespace Lab4;

public class DepartmentHeadsByNameComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is DepartmentHead departmentHead1 && y is DepartmentHead departmentHead2)
            return departmentHead1.Name.CompareTo(departmentHead2.Name);

        return 0;
    }
}