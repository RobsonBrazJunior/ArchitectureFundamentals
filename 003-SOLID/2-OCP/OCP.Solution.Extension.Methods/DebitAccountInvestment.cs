namespace SOLID._2_OCP.OCP.Solution.Extension.Methods
{
	internal static class DebitAccountInvestment
	{
		public static string Debit(this DebitAccount debitAccount)
		{
			// DO SOME LOGIC FOR INVESTMENT ACCOUNT
			return debitAccount.FormatTransaction();
		}
	}
}
