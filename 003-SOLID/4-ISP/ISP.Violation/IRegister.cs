namespace SOLID._4_ISP.ISP.Violation
{
	internal interface IRegister
	{
		void ValidateData();
		void SaveToDatabase();
		void SendEmail();
	}
}
