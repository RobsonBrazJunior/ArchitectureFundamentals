namespace SOLID._1_SRP.SRP.Solution
{
	internal class CostumerService
	{
		internal string AddCostumer(Costumer costumer)
		{
			if (!costumer.Validate())
				return "Invalid Costumer!";

			var repo = new CostumerRepository();
			repo.AddCostumer(costumer);

			EmailService.SendEmail("email@email.com", costumer.Email.Address, "Welcome", "Congratulations! You are registered.");

			return "Costumer registered successful.";
		}
	}
}
