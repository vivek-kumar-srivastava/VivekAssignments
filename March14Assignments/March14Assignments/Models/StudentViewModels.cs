namespace March14Assignments.Models
{

    public class StudentCoursesVM
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<string> CourseTitles { get; set; } = new();

        public int CourseCount => CourseTitles.Count;
    }

    public class CourseDetailVM
    {
        public string Title { get; set; } = string.Empty;

        public int Level { get; set; }

        public string Description { get; set; } = string.Empty;
    }

    public class StudentDetailVM
    {
        public string Name { get; set; } = string.Empty;

        public List<CourseDetailVM> Courses { get; set; } = new();
    }
}