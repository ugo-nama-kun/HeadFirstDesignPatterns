using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void display()
        {
            Console.WriteLine("Im Rubbber Duck!");
        }
    }
}
