using DbFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DbFirstEF.Controllers
{
    public class NorthWindController : Controller
    {
        public IActionResult SpainCustomers()
        {
            NorthWindContext cnt =  new NorthWindContext();
            var spainCustomer = cnt.Customers.Where(x => x.Country == "Spain").Select(x => new SpainCustomerViewModel
            {
                Cid = x.CustomerId,
                Cname = x.ContactName,
                Comname = x.CompanyName
            }).ToList();
            return View(spainCustomer);
        }

        public IActionResult searchCustomer(string contactName)
        {
            NorthWindContext cnt = new NorthWindContext();
            var searchcustomer = cnt.Customers.Where(x => x.ContactName == contactName).Select(x => new Customer
            {
                ContactTitle= x.ContactTitle,
                ContactName = x.ContactName,
                CompanyName = x.CompanyName
            }).ToList();
            var query2 = searchcustomer.Single();
            return View(query2);
        }

   
    }
}
