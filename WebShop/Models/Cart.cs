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
        [Key]
        public int CartID { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }

        public int ProductCount { set; get; }

        public Nullable<double> TotalPrice { set; get; }


        #region 导航属性
        public virtual User User { set; get; }
        public virtual List<CartItem> CartItems { set; get; }
        #endregion
    }
}