using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebShop.Model
{
    public class OrderDetail
    {
        [Key]
        public int ODID { get; set; }

        
        public int ProductID { get; set; }
        public int Count { get; set; }
        public double CurrentPrice { get; set; }

        
        public int OrderID { get; set; }


        #region 导航属性
        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        #endregion
    }
}