using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Index(int? id)
        {
            Employee employee = EmployeeRepo.EmployeeList.Find(e => e.ID == id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Index([FromQuery]string name)
        {
            Employee employee = EmployeeRepo.EmployeeList.Find(e => e.Name == name);
            return View(employee);
        }

        public IActionResult Index()
        {   
            return View();
        }
    }
}