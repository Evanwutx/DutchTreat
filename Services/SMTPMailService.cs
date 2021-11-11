using Microsoft.Extensions.Logging;

namespace DutchTreat.Services
{
    public class SMTPMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        public SMTPMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string to, string subject, string body)
        {
            _logger.LogInformation($"ToTo: {to} Subject: {subject} BodyBody: {body}");
        }
    }
}
