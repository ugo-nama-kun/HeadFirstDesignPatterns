using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface quackBehavior
    {
        public void quack();
    }

    public class Quack : quackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Gaa! Gaa!");
        }
    }

    public class Squeak : quackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quu! Quu!");
        }
    }

    public class MuteQuack : quackBehavior
    {
        public void quack()
        {
            Console.WriteLine(".... (no quack)");
        }
    }
}
