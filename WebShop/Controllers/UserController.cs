using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class UserController : Controller
    {
        Model.MyDBContext db = new Model.MyDBContext();

        // GET: User
        public ActionResult Index()
        {
            var list = db.Cates.ToList();
            ViewBag.list = list;
            return View();
        }


        //超级用户的登录
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(Model.AdminUsers model)
        {
            var findobj = db.AdminUsers.SingleOrDefault(a => a.UserName == model.UserName && a.PassWord == model.PassWord);
            //找到登录信息
            if (findobj!=null) {
                return RedirectToAction("Index");
            }

            return View();
        }

        //添加商品

    }
}