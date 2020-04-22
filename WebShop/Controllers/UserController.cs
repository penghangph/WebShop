using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebShop.Controllers
{
    public class UserController : Controller
    {
        Model.MyDBContext db = new Model.MyDBContext();

        //拦截器 过滤非登录用户
        [Authorize]
        // GET: User
        public ActionResult Index()
        {
            var list = db.Cates.ToList();
            ViewBag.list = list;
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();//签出票据
            return Redirect("/User/AdminLogin");
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
                
                FormsAuthentication.SetAuthCookie(findobj.UserName,false);//设置登录票据

                return RedirectToAction("Index");
            }

            return View();
        }

        //添加商品

        #region actionresult 返回类型
        public ActionResult result1()
        {
            return new EmptyResult();//返回空结果
        }
        public ActionResult result2()
        {
            return Content("<h3>hello world</h3>"); //返回内容 可执行js代码
        }

        public ActionResult result3()
        {
            return JavaScript("var i=1;alert('i');");//返回js代码 不执行
        }

      
        public ActionResult result4()
        {
            return Json(new { id=1,name="zhangsan"},JsonRequestBehavior.AllowGet);//返回json对象 允许get请求
        }

        public ActionResult result5()
        {
            return Redirect("/Home/Index");//返回重定向结果
        }

        public ActionResult result6()
        {
            return RedirectToAction("Index","Home");//返回重定向到home控制器 index方法
        }

        public ActionResult result7()
        {
            return RedirectToRoute("default", new { controller = "Home", action = "Index" });//返回重定向到路由
        }

        public ActionResult result8()
        {
            return HttpNotFound();//返回http未找到 404错误
        }

        public ActionResult result9()
        {
            return new HttpUnauthorizedResult("未登录");//返回未经授权的结果
        }


        public ActionResult result10()
        {
            Stream st = new FileStream(Server.MapPath("/") + "/Content/1.doc", FileMode.Open);

            FileStreamResult fs = new FileStreamResult(st, "application/msword");
            fs.FileDownloadName = "word文档.doc";
            
            return fs;
        }



        public ActionResult DoSm()
        {
            return  Content("<script>alert('hello world！');</script> " );
        }

        #endregion

    }
}