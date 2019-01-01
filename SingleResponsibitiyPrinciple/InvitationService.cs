using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibitiyPrinciple
{
    public class InvitationService
    {
        public void SendInvite(string email, string firstName, string lastName)
        {
            // Validates the name.
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Name is not valid!");
            }

            // validating the email.
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email is not valid!!");
            }

            // Logic for sending e-mail.
            var client = new SmtpClient();
            client.Send(new MailMessage("mysite@nowhere.com", email) { Subject = "Please join me at my party!" });


            // Log the event of successful email delivery.
            const string filePath = @"D:\IDGLog.txt";
            const string message = "Email sent successfully!";

            using (var streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
