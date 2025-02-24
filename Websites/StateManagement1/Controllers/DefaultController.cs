using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace StateManagement1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            //Default/Index2
            ViewData["a"] = 100;
            //ViewBag.a = 100;
            TempData["b"] = 200;
            return View();
            //return RedirectToAction("Index2");  // will not be able to access ViewData from other view
        }
        // /Default/Index2
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Session1()
        {
            //HttpContext.Session.SetInt32("var1", 1000);
            //int? i = HttpContext.Session.GetInt32("var1");

            //HttpContext.Session.SetString("var2", "aaaa");
            //string s = HttpContext.Session.GetString("var2");



            //HttpContext.Session.Set("var1", bytearr);
            //byte[] barr = HttpContext.Session.Get("var1");

            //HttpContext.Session.SetString("var1", "Hello");
            //string s = HttpContext.Session.GetString("var1");

            //HttpContext.Session.SetInt32("var2", 123);
            //int i = HttpContext.Session.GetInt32("var2").Value;






            //HttpContext.Session.Set()
            //HttpContext.Session.Set("key1", byte_arr);
            //byte_arr = HttpContext.Session.Get("key1");

            //ViewData["key"] = value;


            //HttpContext.Session.Set("key", value);
            //HttpContext.Session.Get()

            HttpContext.Session.SetInt32("a", 10);
            HttpContext.Session.SetString("b", "abcd");

            //decimal d = 1.2M;
            //HttpContext.Session.SetString("d", d.ToString());
            //string sd = HttpContext.Session.GetString("d");
            //d = decimal.Parse(sd);

            Employee emp = new Employee { EmpNo=1,Name="Vikram"};
            string jsonEmp = JsonSerializer.Serialize<Employee>(emp);
            HttpContext.Session.SetString("emp", jsonEmp);

            //HttpContext.Session.SetString("emp", JsonSerializer.Serialize<Employee>(emp));

            return View();

        }
        public IActionResult Session2()
        {
            //HttpContext.Session.Clear();
            int a = HttpContext.Session.GetInt32("a").Value;
            string b = HttpContext.Session.GetString("b");
            
            string e = HttpContext.Session.GetString("emp");
            Employee emp = JsonSerializer.Deserialize<Employee>(e);

            ViewBag.name = emp.Name;
            return View();

        }
        public IActionResult Session3()
        {
            return View();

        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
    }

}