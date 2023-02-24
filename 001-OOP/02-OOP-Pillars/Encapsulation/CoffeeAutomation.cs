using _00P._02_OOP_Pillars.Polymorphism;

namespace _00P._02_OOP_Pillars.Encapsulation
{
	internal class CoffeeAutomation
	{
		internal void ServeCoffee()
		{
			var espresso = new EspressoMachine();
			espresso.TurnOn();
			espresso.PrepareCoffee();
			espresso.TurnOff();
		}
	}
}
