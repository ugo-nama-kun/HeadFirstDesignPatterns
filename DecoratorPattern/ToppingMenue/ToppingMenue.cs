using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            SetDescription(beverage.GetDescription() + ", Mocha");
        }

        public override double Cost()
        {
            return 0.20 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }

    public class SteamMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamMilk(Beverage beverage)
        {
            this.beverage = beverage;
            SetDescription(beverage.GetDescription() + ", Steam Milk");
        }

        public override double Cost()
        {
            return 0.10 + this.beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }

    public class SoyMilk : CondimentDecorator
    {
        Beverage beverage;

        public SoyMilk(Beverage beverage)
        {
            this.beverage = beverage;
            SetDescription(beverage.GetDescription() + ", Soy Milk");
        }

        public override double Cost()
        {
            return 0.15 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }

    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            SetDescription(beverage.GetDescription() + ", Whip");
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() ;
        }
    }
}
