using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SDD_Hardening.Controllers
{
    public class Project1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}