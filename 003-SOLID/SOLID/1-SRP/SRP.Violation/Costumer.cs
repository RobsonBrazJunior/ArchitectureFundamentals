using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID._1_SRP.SRP.Violation
{
	internal class Costumer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Cpf { get; set; }
		public DateTime RegistrationDate { get; set; }

		internal string AddCostumer()
		{
			if (!Email.Contains('@'))
				return "Costumer with invalid e-mail!";

			if (Cpf.Length != 11)
				return "Costumer with invalid CPF!";

			using (var connection = new SqlConnection())
			{
				var command = new SqlCommand();

				connection.ConnectionString = "MyConnectionString";
				command.Connection = connection;
				command.CommandType = CommandType.Text;
				command.CommandText = "INSERT INTO COSTUMER (NAME, EMAIL, CPF, REGISTRATIONDATE) VALUES (@name, @email, @cpf, @registrationdate);";

				command.Parameters.AddWithValue("name", Name);
				command.Parameters.AddWithValue("email", Email);
				command.Parameters.AddWithValue("cpf", Cpf);
				command.Parameters.AddWithValue("registrationdate", RegistrationDate);

				connection.Open();
				command.ExecuteNonQuery();
			}

			var mail = new MailMessage("email@email.com", Email);
			var client = new SmtpClient()
			{
				Port = 25,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Host = "localhost"
			};

			mail.Subject = "Welcome";
			mail.Body = "Congratulations! You are registered.";

			return "Costumer registered successful.";
		}
	}
}
