namespace _00P._02_OOP_Pillars.Inheritance
{
	internal class Process
	{
		public void Execute()
		{
			var employee = new Employee()
			{
				Name = "Name of a Person",
				Birthday = Convert.ToDateTime("1990/01/01"),
				AdmissionDate = DateTime.Now,
				Registry = "0123456"
			};

			employee.CalculateAge();
		}
	}
}
