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

            db.Cates.Add(new Model.ProductCate() { CateName="家用电器", ParentID=null });
            db.Cates.Add(new Model.ProductCate() { CateName = "电脑/办公", ParentID = null });
            db.Cates.Add(new Model.ProductCate() { CateName = "家装/厨具", ParentID = null });
            db.Cates.Add(new Model.ProductCate() { CateName = "服装", ParentID = null });


            db.SaveChanges();
            return View();
        }
    }
}