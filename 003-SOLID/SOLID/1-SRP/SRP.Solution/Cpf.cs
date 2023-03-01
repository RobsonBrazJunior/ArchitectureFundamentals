namespace SOLID._1_SRP.SRP.Solution
{
	internal class Cpf
	{
		public string Number { get; set; }

		internal bool Validate()
		{
			return Number.Length == 11;
		}
	}
}
