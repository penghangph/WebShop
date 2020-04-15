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

        [ForeignKey("ProductID")]
        public string ProductID { get; set; }
        public int Count { get; set; }
        public double CurrentPrice { get; set; }

        [ForeignKey("OrderID")]
        public int OrderID { get; set; }


        #region 导航属性
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        #endregion
    }
}