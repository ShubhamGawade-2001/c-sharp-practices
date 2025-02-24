using Microsoft.AspNetCore.Mvc;

namespace AddingViews.Controllers
{
    public class DefaultController : Controller
    {
        //empty view with use layout - no layout specified - uses ViewStart
        public IActionResult Index1()
        {
            return View();
        }
        //empty view with use layout - layout specified - layout2
        public IActionResult Index2()
        {
            return View();
        }

        //empty view with dont use layout - no layout specified - layout=null
        public IActionResult Index3()
        {
            return View();
        }
       

    }
}
