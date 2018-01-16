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
        public static ImageViewModel Images { get; set; }

        public HomeController(ImageViewModel newModel)
        {
            Images = newModel;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            if (Images.GameOver==0)
            {
                Images.GameOver = 4;
                Images.GenerateImageList();
                return View(Images);
            }            

            return View(Images);
        }

        [HttpPost("TurnUpTheFirstCard")]
        public IActionResult TurnUpTheCard()
        {
            Images.CardToCheck = 0;
            Images.CheckTheCard();
            if (Images.GameOver == 2)
            {
                return Redirect("/death");
            }
            else if (Images.GameOver == 1)
            {
                return Redirect("/win");
            }

            return RedirectToAction("Index");
        }

        [HttpPost("TurnUpTheSecondCard")]
        public IActionResult TurnUpTheSecondCard()
        {
            Images.CardToCheck = 1;
            Images.CheckTheCard();
            if (Images.GameOver == 2)
            {
                return Redirect("/death");
            }
            else if (Images.GameOver == 1)
            {
                return Redirect("/win");
            }

            return RedirectToAction("Index");
        }

        [HttpPost("TurnUpTheThirdCard")]
        public IActionResult TurnUpTheThirdCard()
        {
            Images.CardToCheck = 2;
            Images.CheckTheCard();
            if (Images.GameOver == 2)
            {
                return Redirect("/death");
            }
            else if (Images.GameOver == 1)
            {
                return Redirect("/win");
            }

            return RedirectToAction("Index");
        }        
    }
}
