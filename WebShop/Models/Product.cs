using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebShop.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Title { get; set; }

        [ForeignKey("CateID")]
        public int CateID { get; set; }
        public double MarketPrice { get; set; }
        public double LocalPrice { get; set; }
        public string Content { get; set; }
        public System.DateTime PostTime { get; set; }
        public int Cnt { get; set; }
        public string ImageURL { get; set; }

        #region 导航属性
        public ProductCate ProductCate { get; set; }

        public List<OrderDetail> OrderDetails { set; get; }

        public List<CartItem> CartItems { set; get; }
        #endregion
    }
}