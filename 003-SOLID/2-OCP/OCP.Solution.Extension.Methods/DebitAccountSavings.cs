namespace SOLID._2_OCP.OCP.Solution.Extension.Methods
{
	internal static class DebitAccountSavings
	{
		public static string Debit(this DebitAccount debitAccount)
		{
			// DO SOME LOGIC FOR SAVINGS ACCOUNT
			return debitAccount.FormatTransaction();
		}
	}
}
