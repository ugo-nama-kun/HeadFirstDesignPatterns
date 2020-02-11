using System;

namespace StrategyPattern
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck myduck = new MallardDuck();
            myduck.display(); 
            myduck.performFly();
            myduck.performQuack();

            myduck = new RedHeadDuck();
            myduck.display();
            myduck.performFly(); 
            myduck.performQuack();

            myduck = new RubberDuck();
            myduck.display();
            myduck.performFly();
            myduck.performQuack();

            myduck = new DecoyDuck();
            myduck.display();
            myduck.performFly();
            myduck.performQuack();

            myduck.setFlyBehavior(new FlyJet());
            myduck.performFly();
        }

    }
}
