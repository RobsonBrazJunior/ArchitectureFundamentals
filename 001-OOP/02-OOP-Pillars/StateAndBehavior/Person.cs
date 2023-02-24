namespace _00P._02_OOP_Pillars.StateAndBehavior
{
	internal class Person
	{
		// State
		public string Name { get; set; }
		public DateTime Birthday { get; set; }

		// Behavior
		public int CalculateAge()
		{
			var today = DateTime.Now;
			var age = today.Year - Birthday.Year;

			if (today < Birthday.AddYears(age))
				age--;

			return age;
		}
	}
}
