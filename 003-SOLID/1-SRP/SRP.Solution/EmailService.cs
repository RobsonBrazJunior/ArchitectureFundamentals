using System.Net.Mail;

namespace SOLID._1_SRP.SRP.Solution
{
	internal static class EmailService
	{
		internal static void SendEmail(string from, string to, string subject, string message)
		{
			var mail = new MailMessage(from, to);
			var client = new SmtpClient()
			{
				Port = 25,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Host = "localhost"
			};

			mail.Subject = subject;
			mail.Body = message;
			client.Send(mail);
		}
	}
}
