namespace _00P._01_ClassVsObject
{
	internal class Object
	{
		internal Object()
		{
			var house = new House()
			{
				Size = 100,
				Floors = 2,
				Value = 1_000_000,
				ParkingNumber = 3
			};
		}
	}
}
