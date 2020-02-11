using System;

namespace StrategyPattern
{
	public interface flyBehavior
	{
		public void fly();
	}

	public class FlyWithWings : flyBehavior
	{
		public void fly()
		{
			Console.WriteLine("I'm Flying!");
		}
	}

	public class FlyNoWay : flyBehavior
	{
		public void fly()
		{
			Console.WriteLine("I can not fly.");
		}
	}

	public class FlyJet : flyBehavior
	{
		public void fly()
		{
			Console.WriteLine("Fly by Jet! GO!!!!");
		}
	}
}
