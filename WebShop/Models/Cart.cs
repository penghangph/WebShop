using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebShop.Model
{
    public class Cart
    {
        [ForeignKey("User")]
        public int CartID { get; set; }

        /// <summary>
        /// 废弃属性 等同于 CartID
        /// </summary>
        public int UserID { get; set; }

        public int ProductCount { set; get; }

        public Nullable<double> TotalPrice { set; get; }


        #region 导航属性
        
        public virtual User User { set; get; }


        public List<CartItem> CartItems { set; get; }
        #endregion
    }
}