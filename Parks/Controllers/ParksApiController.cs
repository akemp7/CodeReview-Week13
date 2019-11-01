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

        // GET api/parks
        [HttpGet]
        public ActionResult <IEnumerable<Park>> Get(int parkId, string name, string land, string state)
        {
            var query = _db.Parks.AsQueryable();
            if(parkId != 0)
            {
                query = query.Where(p => p.ParkId == parkId);
            }   
            if(name != null)
            {
                query = query.Where(n => n.Name == name);
            }
            if(land != null)
            {
                query = query.Where(l => l.Land == land);
            }
            if(state != null)
            {
                query = query.Where(s => s.State == state);
            }

            return query.ToList();
        }

        // POST api/parks
        [HttpPost]
         public void Post([FromBody] Park parks)
         {
            _db.Parks.Add(parks);
            _db.SaveChanges();
         }
    }
}