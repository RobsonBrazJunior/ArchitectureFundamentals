namespace SOLID._2_OCP.OCP.Solution.Extension.Methods
{
	internal static class DebitAccountChecking
	{
		public static string Debit(this DebitAccount debitAccount)
		{
			// DO SOME LOGIC FOR CHECKING ACCOUNT
			return debitAccount.FormatTransaction();
		}
	}
}
