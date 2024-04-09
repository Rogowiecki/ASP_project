using Microsoft.AspNetCore.Mvc;
using Rating_ASP.Models;
using System.Diagnostics;

namespace Rating_ASP.Controllers
{
    public class InsuranceController : Controller
    {
        public IActionResult Trap()
        {
            var projects = PersonsStorage.Persons;
            return View();
        }

        public IActionResult Index()
        {
            var projects = PersonsStorage.Persons;
            return View(projects);
        }

        public IActionResult AddPerson()
        {         
            return View();
        }

        [HttpPost]
        public IActionResult SavePerson(string fio, int age, string insuranceType, decimal mounthPayment)
        {
            Person project = new Person(fio, age, insuranceType, mounthPayment);
            PersonsStorage.Persons.Add(project);

            return RedirectToAction("Index", "Insurance");
        }

        [HttpPost]
        public IActionResult AddPerson(string fio, int age, string insuranceType, decimal mounthPayment)
        {
            var person = new Person(fio, age, insuranceType, mounthPayment);
            PersonsStorage.Persons.Add(person);

            return RedirectToAction("Index", "Insurance");
        }


    }
}
