using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebShop.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public Nullable<DateTime> StartTime { get; set; }
        public Nullable<DateTime> EndTime { get; set; }
        public string UserAddress { get; set; }
        public string State { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public double TotalPrice { get; set; }

        #region 导航属性
        public virtual User User { set; get; }
        public virtual List<OrderDetail> OrderDetails { set; get; }
        #endregion
    }
}