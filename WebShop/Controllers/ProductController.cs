using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    /// <summary>
    /// 产品有关的控制器
    /// </summary>
    public class ProductController : Controller
    {
        Model.MyDBContext db = new Model.MyDBContext();

        #region 分类操作

        [HttpGet]
        public ActionResult AddCate()
        {

            List<SelectListItem> myselect = new List<SelectListItem>();

            var list = db.Cates.ToList();

            foreach (var item in list)
            {
                myselect.Add(new SelectListItem() { Text = item.CateName, Value = item.CateID.ToString() });
            }

            ViewBag.list = myselect;
            return View();
        }

        [HttpPost]
        public ActionResult AddCate(string CateName,int pid)
        {
            Model.ProductCate model = new Model.ProductCate() { CateName=CateName,ParentID=pid };

            db.Cates.Add(model);
            db.SaveChanges();

            return RedirectToAction("Index","User");
        }


        [HttpGet]
        public ActionResult EditCate(int id)
        {
            var obj = db.Cates.SingleOrDefault(a=>a.CateID==id);

            //绑定下拉列表
            List<SelectListItem> myselect = new List<SelectListItem>();

            var list = db.Cates.ToList();

            foreach (var item in list)
            {
                if (obj.ParentID==item.CateID)
                    myselect.Add(new SelectListItem() { Text = item.CateName, Value = item.CateID.ToString(), Selected=true });
                else
                    myselect.Add(new SelectListItem() { Text = item.CateName, Value = item.CateID.ToString() });
            }

            ViewBag.list = myselect;

            return View(obj);
        }


        public ActionResult EditCate(int CateID,string CateName,int pid)
        {
            var obj = db.Cates.SingleOrDefault(a=>a.CateID==CateID);

            if (obj != null) {
                obj.CateName = CateName;
                obj.ParentID = pid;
            }

            db.SaveChanges();

            return RedirectToAction("Index","User");

        }

        #endregion

        #region 产品操作
        public ActionResult InitData()
        {
            //添加产品

            return Content("");
        }

        public ActionResult ProductList()
        {
            return Content("");
        }
        #endregion

    }
}