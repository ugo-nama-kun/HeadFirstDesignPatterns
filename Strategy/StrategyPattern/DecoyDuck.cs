using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void display()
        {
            Console.WriteLine("... (I'm a decoy duck)");
        }
    }
}
