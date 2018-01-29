using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaOrientationExam.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaOrientationExam.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public PlateService PlateService { get; set; }

        public HomeController(PlateService PlateService)
        {
            this.PlateService = PlateService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(PlateService.ListAll());
        }

        [HttpGet("search")]
        public IActionResult Index([FromQuery] string q, [FromQuery] int police, [FromQuery] int diplomat)
        {
            var searchedList = PlateService.Search(q, police, diplomat);
            return View(searchedList);
        }

        [HttpGet("search/{brand}")]
        public IActionResult Index([FromRoute] string brand)
        {
            var searchedList = PlateService.SearchBrand(brand);
            return View(searchedList);
        }

        [HttpGet("api/search/{brand}")]
        public IActionResult Search([FromRoute] string brand)
        {
            var data = PlateService.SearchBrand(brand);
            return Json(new { result= "ok", data });
        }
    }
}
