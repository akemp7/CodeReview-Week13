using System;
using System.Collections.Generic;
using System.Linq;
using Parks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Parks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ParksApiController: ControllerBase
    {
        private ParksContext _db;
        public ParksApiController(ParksContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Park>> Get()
    }
}