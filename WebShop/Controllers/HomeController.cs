using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {

        Model.MyDBContext db = new Model.MyDBContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}