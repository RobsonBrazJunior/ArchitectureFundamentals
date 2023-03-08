namespace SOLID._2_OCP.OCP.Solution
{
	internal abstract class DebitAccount
	{
		public string NumberTransaction { get; set; }

		public abstract string Debit(decimal value, string account);

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
