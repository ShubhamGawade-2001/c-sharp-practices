using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        /*http://localhost:5120/default/index/10?a=1&b=2&c=3
http://localhost:5120/default/index/10?c=3
http://localhost:5120/default/index/10?a=1&c=3
         * 
         */
        public IActionResult Index( int? id,int a=10, int b=20,int c=30)
        {
            //if (id == null)
            //    return NotFound();
            //ExpandoObject
            ViewBag.id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;

            return View();
        }
    }
}
