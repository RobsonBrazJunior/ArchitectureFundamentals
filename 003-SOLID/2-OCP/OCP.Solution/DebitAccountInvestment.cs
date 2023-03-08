namespace SOLID._2_OCP.OCP.Solution
{
	internal class DebitAccountInvestment : DebitAccount
	{
		public override string Debit(decimal value, string account)
		{
			// DO SOME LOGIC FOR INVESTMENT ACCOUNT
			return FormatTransaction();
		}
	}
}
