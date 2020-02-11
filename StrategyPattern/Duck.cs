using System;

namespace StrategyPattern
{
	public abstract class Duck
	{
		protected flyBehavior flyBehavior;
		protected quackBehavior quackBehavior;

		public Duck()
		{
		}

		public abstract void display();

		public void performFly()
		{
			flyBehavior.fly();
		}

		public void performQuack()
		{
			quackBehavior.quack();
		}

		public void performSwim()
		{
			Console.WriteLine("all duck can swim!");
		}

		public void setFlyBehavior(flyBehavior fb)
		{
			flyBehavior = fb;
		}

		public void setQuackBehavior(quackBehavior qb)
		{
			quackBehavior = qb;
		}
	}
}
