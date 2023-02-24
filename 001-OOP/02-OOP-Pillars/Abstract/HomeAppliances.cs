namespace _00P._02_OOP_Pillars.Abstract
{
	internal abstract class HomeAppliances
	{
		private readonly string _name;
		private readonly int _voltage;

		protected HomeAppliances(string name, int voltage)
		{
			_name = name;
			_voltage = voltage;
		}

		internal abstract void TurnOn();
		internal abstract void TurnOff();
	}
}
