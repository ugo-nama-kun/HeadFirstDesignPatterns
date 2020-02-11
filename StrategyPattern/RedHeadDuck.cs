using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("Red Head Duck!");
        }
    }
}
