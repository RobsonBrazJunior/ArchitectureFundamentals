namespace SOLID._4_ISP.ISP.Violation
{
	internal class ProductRegistration : IRegister
	{
		public void ValidateData()
		{
			throw new NotImplementedException();
		}

		public void SaveToDatabase()
		{
			throw new NotImplementedException();
		}

		public void SendEmail()
		{
			throw new NotImplementedException("This method does not work here!");
		}
	}
}
