using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RorasCargo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RorasCargo.Controllers
{
    [Route("rocket")]
    public class CargoController : Controller
    {
        public Cargo cargo { get; set; }

        public CargoController(Cargo cargo)
        {
            this.cargo = cargo;
        }

        [HttpGet("")]
        public IActionResult CargoList()
        {
            return Json(new { caliber25 = cargo.caliber25, caliber30 = cargo.caliber30, caliber50 = cargo.caliber50, shipstatus = cargo.IsEmpty, ready = cargo.Ready });
        }

        [HttpGet("fill")]
        public IActionResult CargoFill([FromQuery] string caliber, [FromQuery] int amount)
        {
            if (caliber != null && amount != 0)
            {
                cargo.FillInAmmo(caliber, amount);
                string cargostatus = cargo.CheckCargoStatus();
                return Json(new { recieved = amount, amount = amount, shipstatus = cargostatus, ready = cargo.Ready });
            }
            return Json(new { failure = "yes it is true" });
        }
    }
}