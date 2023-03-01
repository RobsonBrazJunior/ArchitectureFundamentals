namespace SOLID._1_SRP.SRP.Solution
{
	internal class Email
	{
		public string Address { get; set; }

		internal bool Validate()
		{
			return Address.Contains('@');
		}
	}
}
