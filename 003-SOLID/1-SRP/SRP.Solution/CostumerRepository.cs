using System.Data.SqlClient;
using System.Data;

namespace SOLID._1_SRP.SRP.Solution
{
	internal class CostumerRepository
	{
		internal void AddCostumer(Costumer costumer)
		{
			using (var connection = new SqlConnection())
			{
				var command = new SqlCommand();

				connection.ConnectionString = "MyConnectionString";
				command.Connection = connection;
				command.CommandType = CommandType.Text;
				command.CommandText = "INSERT INTO COSTUMER (NAME, EMAIL, CPF, REGISTRATIONDATE) VALUES (@name, @email, @cpf, @registrationdate);";

				command.Parameters.AddWithValue("name", costumer.Name);
				command.Parameters.AddWithValue("email", costumer.Email);
				command.Parameters.AddWithValue("cpf", costumer.Cpf);
				command.Parameters.AddWithValue("registrationdate", costumer.RegistrationDate);

				connection.Open();
				command.ExecuteNonQuery();
			}

		}
	}
}
