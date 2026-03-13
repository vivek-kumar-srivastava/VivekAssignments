using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCdemo.Models;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string sampledemo1()
        {
            return "sampledemo1 in home controller";
        }

        public string sampledemo2(int age,string name)
        {
            return $"The name {name} is of age {age}";
        //https://localhost:7099/home/sampledemo2?name=ravi&age=24
        }


        public IActionResult sampledemo3()
        {
            int age = 24;
            string name = "Kishore Kumar";
            ViewBag.Name = name;
            ViewBag.Age=age;
            ViewData["Message"] = "sampledemo3";
            ViewData["Year"] = DateTime.Now.Year;
            return View();
        }

        Employee_ obj = new Employee_()
        {
            EmployeeID = 1,
            EmpName = "Vivek",
            Salary = 90000,
        };


        List<Employee_> emplist = new List<Employee_>()
        {
            new Employee_{EmployeeID=101,EmpName="Adam", Salary=97000, ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR6lgwn1YvWp1Yazg6mTsUpPXDKgqwMFrdBcQ&s"},
             new Employee_{EmployeeID=102,EmpName="Megha", Salary=67000, ImageUrl="https://img.freepik.com/free-photo/confident-cheerful-young-businesswoman_1262-20881.jpg?semt=ais_hybrid&w=740&q=80"},
               new Employee_{EmployeeID=103,EmpName="Hannibal", Salary=70000, ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRadPuX9jOTNqV4OMq4Y96gHY8nIx2cypBjsw&s"},
                 new Employee_{EmployeeID=104,EmpName="Narendra", Salary=77000, ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTEYEI5nU2R_FOfpmEBKHJW7TXrT7PKTdmtAw&s"},

        };
        public IActionResult collectionofobjectpassing()
        {
            return View(emplist);
        }
        public IActionResult singleobjectpass()
        {

            return View(obj);
        }


        public IActionResult display()
{
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
