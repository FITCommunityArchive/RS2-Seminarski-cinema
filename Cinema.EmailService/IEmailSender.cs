using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.EmailService
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
        Task SendEmailAsync(IEnumerable<string> to, string subject, string content, IFormFileCollection attachments);
        Task SendEmailAsync(IEnumerable<string> to, string subject, string content);
    }
}
