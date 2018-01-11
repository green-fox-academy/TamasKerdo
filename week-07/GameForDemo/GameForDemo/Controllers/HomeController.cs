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
    [Route("")]
    public class HomeController : Controller
    {        
        public static ImageViewModel Images { get; set; } = new ImageViewModel();
        [HttpGet]
        public IActionResult Index()
        {
            if (Images.GameOver==0)
            {
                Images.GenerateImageList();
                return View(Images);
            }

            return View(Images);

        }
        [HttpPost]
        public IActionResult TurnUpTheCard()
        {
            Images.GenerateImageList();
            return View(Images);
        }
    }
}
