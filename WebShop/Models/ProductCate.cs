using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Model
{
    public class ProductCate
    {
        [Key]
        public int CateID { get; set; }
        public string CateName { get; set; }
        public Nullable<int> ParentID { get; set; }

       
        public List<Product> Product { get; set; }
    }
}