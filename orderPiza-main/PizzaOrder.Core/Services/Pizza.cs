using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Core.Services
{
    public abstract class Pizza
    {
        public virtual void Prepare()
        {
            Console.WriteLine("General preparation of Pizza!");
        }

        public virtual void Bake()
        {
            Console.WriteLine("General Baking method of Pizza!");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting Pizza in standard size!");
        }

        public virtual void Box()
        {
            Console.WriteLine("Boxing Pizza!");
        }

        public virtual void Sent()
        {
            Console.WriteLine("Pizza is sent!");
        }
    }
}
