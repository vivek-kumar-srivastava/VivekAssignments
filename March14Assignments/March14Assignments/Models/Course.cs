using System;
using System.Collections.Generic;

namespace March14Assignments.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Level { get; set; }

    public int AuthorId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
