namespace SOLID._2_OCP.OCP.Solution.Extension.Methods
{
	internal class DebitAccount
	{
		public string NumberAccount { get; set; }
		public decimal Value { get; set; }
		public string NumberTransaction { get; set; }

		public string FormatTransaction()
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUWVYXZ0123456789";
			var random = new Random();
			NumberTransaction =
				new string(Enumerable.Repeat(chars, 15).Select(s => s[random.Next(s.Length)]).ToArray());

			return NumberTransaction;
		}
	}
}
