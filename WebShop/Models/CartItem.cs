using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebShop.Model
{
    public class CartItem
    {
        [Key]
        public int CIID { set; get; }

        [ForeignKey("ProductID")]
        public int ProductID { set; get; }

        [ForeignKey("CartID")]
        public int CartID { get; set; }
        public int Count { set; get; }

        public double CurrentPrice { set; get; }

        public DateTime AddTime { set; get; }



        #region 导航属性
        public Product Product { set; get; }
        public Cart Cart { set; get; }
        #endregion
    }
}