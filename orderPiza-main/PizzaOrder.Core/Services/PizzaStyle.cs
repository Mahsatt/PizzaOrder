using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Core.Services
{
    class SpecialStylePeperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making Special style of peperoni pizza.");
        }
    }

    class SpecialStyleMeatPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making Special style of meat pizza.");
        }
    }

    class StandardStylePeperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making Standard style of peperoni pizza.");
        }
    }

    class StandardStyleMeatPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making Standard style of meat pizza.");
        }
    }

    class FamilyStylePeperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making Family style of Peperoni pizza.");
        }

        public override void Box()
        {
            Console.WriteLine("Using Family Box.");
        }
    }

    class FamilyStyleMeatPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making Family style of meat pizza.");
        }
        public override void Box()
        {
            Console.WriteLine("Using Family Box.");
        }
    }
}

