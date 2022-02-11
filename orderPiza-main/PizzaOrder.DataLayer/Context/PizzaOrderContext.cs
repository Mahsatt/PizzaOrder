using Microsoft.EntityFrameworkCore;
using PizzaOrder.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.EntityFrameworkCore;

namespace PizzaOrder.DataLayer.Context
{
   public class PizzaOrderContext : DbContext
    {

        public PizzaOrderContext(DbContextOptions<PizzaOrderContext> options) : base(options)
        {

        }


        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetaile> OrderDetaile { get; set; }


    }
}
