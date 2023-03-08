namespace SOLID._2_OCP.OCP.Violation
{
	internal class DebitAccount
	{
		public void Debit(decimal value, string account, TypeAccount typeAccount)
		{
			if (typeAccount == TypeAccount.Checking)
				throw new NotImplementedException();

			if (typeAccount == TypeAccount.Savings)
				throw new NotImplementedException();
		}
	}
}
