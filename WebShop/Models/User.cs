using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Model
{
    public class User
    {

        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string QQ { get; set; }
        public string Phone { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }


        #region 导航属性
        public virtual Cart Cart { set; get; }

        public virtual List<Order> Orders { set; get; }

        #endregion
    }
}