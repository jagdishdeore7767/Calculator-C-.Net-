using Calculator.Models;
using System;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalController : Controller
    {
        // GET: Cal
        public ActionResult Index()
        {
            return View(new Cal());
        }

        [HttpPost]
        public ActionResult Index(Cal c, string calculator)
        {


            if (calculator == "add")
            {
                c.total = c.no1 + c.no2;
            }
            else if (calculator == "min")
            {
                c.total = c.no1 - c.no2;
            }
            else if (calculator == "mul")
            {
                c.total = c.no1 * c.no2;
            }
            else if (calculator == "div")
            {
                c.total = c.no1 / c.no2;
            }



            //try
            //{
            //    c.total = c.no1 / c.no2;

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            return View(c);
        }
    }
}
