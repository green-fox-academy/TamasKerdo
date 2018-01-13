using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameForDemo.Models;
using GameForDemo.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameForDemo.Controllers
{
    [Route("win")]
    public class WinController : Controller
    {
        public static ImageViewModel Images { get; set; }

        public WinController(ImageViewModel newModel)
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
            Images.NumberOfWins++;
            return Redirect("/");
        }
    }
}