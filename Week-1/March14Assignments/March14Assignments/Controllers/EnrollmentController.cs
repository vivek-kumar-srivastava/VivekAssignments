using March14Assignments.Models;
using March14Assignments.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace March14Assignments.Controllers
{
    public class EnrollmentController : Controller
    {
        private static List<Student> _students;
        private static List<Course> _courses;

        public EnrollmentController()
        {
            if (_courses == null)
            {
                _courses = new List<Course>
        {
            new Course { Id = 1, Title = "Data Structures", Description="Core DS", Level = 1 },
            new Course { Id = 2, Title = "Algorithms", Description="Algo Design", Level = 2 },
            new Course { Id = 3, Title = "Databases", Description="DBMS", Level = 2 },
            new Course { Id = 4, Title = "Web Development", Description="Web Tech", Level = 1 },
            new Course { Id = 5, Title = "Operating Systems", Description="OS Concepts", Level = 3 }
        };
            }

            if (_students == null)
            {
                _students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Courses = new List<Course>{ _courses[0], _courses[1] }},
            new Student { Id = 2, Name = "Bob", Courses = new List<Course>{ _courses[2], _courses[3] }},
            new Student { Id = 3, Name = "Charlie", Courses = new List<Course>{ _courses[4] }},
            new Student { Id = 4, Name = "Diana", Courses = new List<Course>{ _courses[0], _courses[2] }},
            new Student { Id = 5, Name = "Eve", Courses = new List<Course>() }
        };
            }
        }

        public IActionResult Index()
        {
            var studentCourses = _students
      .Where(s => s.Courses.Count > 1)
      .Select(s => new StudentCoursesVM
      {
          Id = s.Id,
          Name = s.Name,
          CourseTitles = s.Courses.Select(c => c.Title).ToList()
      })
      .ToList();

            return View(studentCourses);
        }

        public IActionResult Details(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            var vm = new StudentDetailVM
            {
                Name = student.Name,
                Courses = student.Courses.Select(c => new CourseDetailVM
                {
                    Title = c.Title,
                    Level = c.Level,
                    Description = c.Description
                }).ToList()
            };

            return View(vm);
        }

        public IActionResult Edit(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            var vm = new StudentEditDeleteVM
            {
                Id = student.Id,
                Name = student.Name
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(StudentEditDeleteVM vm)
        {
            var student = _students.FirstOrDefault(s => s.Id == vm.Id);

            if (student != null)
            {
                student.Name = vm.Name;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            var vm = new StudentEditDeleteVM
            {
                Id = student.Id,
                Name = student.Name
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                _students.Remove(student);
            }

            return RedirectToAction("Index");
        }
    }
}