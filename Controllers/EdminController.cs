using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingWebsite.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("vl")]
    [ApiController]
    public class EdminController : ControllerBase
    {
        private readonly IEdminServices _services;
        public EdminController(IEdminServices services)
        {
            _services = services;
        }
        // POST vl/AddEdmin
        [Route("AddEdmin")]
        [HttpPost("AddEdmin")]
        
        public ActionResult<Edmin> AddEdmin(Edmin items)
        {
            var edmin = _services.addEdmin(items);
            if(edmin==null)
            {
                return NotFound();
            }
            return edmin;
        }
        // GET vl/GetEdmin
        [Route("GetEdmin")]
        [HttpGet("GetEdmin")]
        public ActionResult<Dictionary<string,Edmin>> GetEdmin()
        {
            var edmin = _services.getEdmin();
            if(edmin.Count==0)
            {
                return NotFound();
            }
            return edmin;
        }
    }
}