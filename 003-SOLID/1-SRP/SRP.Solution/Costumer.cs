namespace SOLID._1_SRP.SRP.Solution
{
	internal class Costumer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Email Email { get; set; }
		public Cpf Cpf { get; set; }
		public DateTime RegistrationDate { get; set; }

		internal bool Validate()
		{
			return Email.Validate() && Cpf.Validate();
		}
	}
}
