using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        String description = "Unknown Drink";

        public String GetDescription()
        {
            return description;
        }

        public void SetDescription(String description)
        {
            this.description = description;
        }

        public abstract double Cost();
    }
}
