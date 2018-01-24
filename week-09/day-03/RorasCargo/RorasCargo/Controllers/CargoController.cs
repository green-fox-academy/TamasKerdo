using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RorasCargo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RorasCargo.Controllers
{
    [Route("")]
    public class CargoController : Controller
    {
        public Cargo cargo { get; set; }

        public CargoController(Cargo cargo)
        {
            this.cargo = cargo;
        }
        
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet("rocket")]
        public IActionResult CargoList()
        {

        }
    }
}
