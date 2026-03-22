using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;

namespace RoutingDemo.Controllers
{
    public class StudentController : Controller
    {
        List<Student> studList = new List<Student>()
        {
            new Student {Id=101,Name="Kishan",Class="class4"},
            new Student {Id=102,Name="Pawan",Class="class8"},
            new Student {Id=103,Name="Aarti",Class="class9"},
        };
        [Route("studs")]
        public IActionResult GetAllStudents()
        {
            return View(studList);
        }
        [Route("studs/{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = studList.FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        [Route("studsfew")]
        public IActionResult fewcolumns(int id) {
            var fewcolumns = studList.Select(x => new Student
            {
                Class = x.Class,
                Name = x.Name,
            });
            return View(fewcolumns);
        }
    }
}
