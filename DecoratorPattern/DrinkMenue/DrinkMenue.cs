using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{

    public class Espresso : Beverage
    {
        public Espresso()
        {
            SetDescription("Espresso");
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            SetDescription("House Blend");
        }

        public override double Cost()
        {
            return .89;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            SetDescription("DarkRoast");
        }

        public override double Cost()
        {
            return 0.99;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf()
        {
            SetDescription("DeCaf");
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
