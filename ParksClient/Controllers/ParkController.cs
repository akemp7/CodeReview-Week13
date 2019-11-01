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
    public class ParkController : Controller
    {

      
        public ActionResult Create()
        {

           return View(); 
        }

        [HttpPost]
        public ActionResult Create(Park park)
        {
             var newPark = Park.PutPark(park);
            return RedirectToAction("Index", "Home", newPark);
        }
        
        public ActionResult Details (Park park)
        {
            return View(park);
        }

    }
}