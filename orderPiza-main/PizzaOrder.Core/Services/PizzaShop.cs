using System;
using System.Collections.Generic;
using System.Text;
using PizzaOrder.Core.enums;

namespace PizzaOrder.Core.Services
{
    public abstract class PizzaShop
    {
        public Pizza OrderPizza(PizzaTypes type)
        {
            Pizza pizza = CookingPizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Sent();

            return pizza;
        }
        protected abstract Pizza CookingPizza(PizzaTypes type);
    }

    public class SpecialPizzaShop : PizzaShop
    {
        protected override Pizza CookingPizza(PizzaTypes type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case PizzaTypes.Peperoni:
                    pizza = new SpecialStylePeperoniPizza(); break;
                case PizzaTypes.Meat:
                    pizza = new SpecialStyleMeatPizza(); break;
                default:
                    break;
            }
            return pizza;
        }
    }
    public class StandardPizzaShop : PizzaShop
    {
        protected override Pizza CookingPizza(PizzaTypes type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case PizzaTypes.Peperoni:
                    pizza = new StandardStylePeperoniPizza(); break;
                case PizzaTypes.Meat:
                    pizza = new StandardStyleMeatPizza(); break;
                default:
                    break;
            }

            return pizza;
        }
    }
    public class FamilyPizzaShop : PizzaShop
    {
        protected override Pizza CookingPizza(PizzaTypes type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case PizzaTypes.Peperoni:
                    pizza = new FamilyStylePeperoniPizza(); break;
                case PizzaTypes.Meat:
                    pizza = new FamilyStyleMeatPizza(); break;
                default:
                    break;
            }
            return pizza;
        }
    }

}
