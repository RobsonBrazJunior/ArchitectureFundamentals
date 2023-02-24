using _00P._02_OOP_Pillars.Abstract;

namespace _00P._02_OOP_Pillars.Polymorphism
{
	internal class EspressoMachine : HomeAppliances
	{
		internal EspressoMachine(string name, int voltage) : base(name, voltage) { }

		internal EspressoMachine() : base("Default", 220) { }

		private static void HeatWater() { }

		private static void GrindGrains() { }

		internal void PrepareCoffee()
		{
			Test();
			HeatWater();
			GrindGrains();
		}

		internal override void TurnOff()
		{
			throw new NotImplementedException();
		}

		internal override void TurnOn()
		{
			throw new NotImplementedException();
		}

		internal override void Test()
		{
			base.Test();
		}
	}
}
