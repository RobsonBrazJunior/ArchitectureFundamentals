namespace SOLID._2_OCP.OCP.Solution
{
	internal class DebitAccountChecking : DebitAccount
	{
		public override string Debit(decimal value, string account)
		{
			// DO SOME LOGIC FOR CHECKING ACCOUNT
			return FormatTransaction();
		}
	}
}
