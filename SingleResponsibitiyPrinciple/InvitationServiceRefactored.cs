using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibitiyPrinciple
{
    public class InvitationServiceRefactored
    {
        private readonly ValidationService _validationService;
        private readonly LoggingService _loggingService;

        public InvitationServiceRefactored(ValidationService validationService, LoggingService loggingService)
        {
            _validationService = validationService;
            _loggingService = loggingService;
        }

        public void SendInvite(string email, string firstName, string lastName)
        {
            _validationService.Validate(email,firstName, lastName);
            
            var client = new SmtpClient();
            client.Send(new MailMessage("sitename@invites2you.com", email) { Subject = "Please join me at my party!" });

            _loggingService.LogMessage();
        }
    }
}
