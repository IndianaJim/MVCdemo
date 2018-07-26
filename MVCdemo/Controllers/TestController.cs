using MVCdemo.Models;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    //handles user interaction logic
    public class TestController : Controller
    {
        public string MyFirstMethod()
        {
            return "Welcome to my method!";
        }

        public ActionResult MyFirstViewMethod()
        {

            CustomerBusinessAccessLayer b = new CustomerBusinessAccessLayer();
            Customer c = b.GetCustomer();

            ViewBag.CustomerData = c;
            return View("MyFirstView");
        }

    }
}