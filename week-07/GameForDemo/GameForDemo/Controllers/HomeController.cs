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
        
        public IActionResult Index()
        {
            Images.GenerateImageList();
            return View(Images);
        }
    }
}
