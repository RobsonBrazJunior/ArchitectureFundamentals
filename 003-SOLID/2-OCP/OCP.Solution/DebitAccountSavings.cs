namespace SOLID._2_OCP.OCP.Solution
{
	internal class DebitAccountSavings : DebitAccount
	{
		public override string Debit(decimal value, string account)
		{
			// DO SOME LOGIC FOR SAVINGS ACCOUNT
			return FormatTransaction();
		}
	}
}
