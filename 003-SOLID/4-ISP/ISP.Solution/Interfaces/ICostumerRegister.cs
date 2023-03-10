namespace SOLID._4_ISP.ISP.Solution.Interfaces
{
	internal interface ICostumerRegister
	{
		void ValidateData();
		void SaveToDatabase();
		void SendEmail();
	}
}
