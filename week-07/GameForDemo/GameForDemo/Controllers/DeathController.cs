using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameForDemo.Models;
using GameForDemo.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameForDemo.Controllers
{
    [Route("death")]
    public class DeathController : Controller
    {

        public static ImageViewModel Images { get; set; }

        public DeathController(ImageViewModel newModel)
        {
            Images = newModel;
        }

        [HttpGet("")]
        public IActionResult Index()
        {            
            return View(Images);
        }
        
        [HttpPost("restart")]
        public IActionResult TurnUpTheCard()
        {
            Images.GameOver = 0;
             return Redirect("/");
        }

    }
}
