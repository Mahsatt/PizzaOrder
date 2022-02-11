using NUnit.Framework;
using PizzaOrder.Core.enums;
using PizzaOrder.Core.Services;

namespace PizzaTest
{
    public class PizzaTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Order_Should_Return_Pizza_Type()
        {
            PizzaShop shop = new SpecialPizzaShop();
            var result = shop.OrderPizza(PizzaTypes.Peperoni);

            Assert.IsInstanceOf(typeof(Pizza),result);
        }
    }
}
