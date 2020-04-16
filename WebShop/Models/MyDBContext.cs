using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebShop.Model
{
    public class MyDBContext:DbContext
    {
        public MyDBContext() : base("name=DBContainer") { 
        
        }
        public DbSet<Cart> Carts { set; get; }
        public DbSet<CartItem> CartItems { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCate> Cates { set; get; }

        public DbSet<AdminUsers> AdminUsers { set; get; }
        public DbSet<User> Users { set; get; }

    }
}