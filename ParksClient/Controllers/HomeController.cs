using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ParksClient.Models;

namespace ParksClient.Controllers
{
    public class HomeController : Controller
    {
     [HttpGet("/")]
        public IActionResult Index()
        {
            var allParks = Park.GetParks();
            return View(allParks);
        }
    }
}
