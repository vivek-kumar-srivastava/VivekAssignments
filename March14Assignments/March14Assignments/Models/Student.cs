using System;
using System.Collections.Generic;

namespace March14Assignments.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
