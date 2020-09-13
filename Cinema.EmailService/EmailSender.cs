using Cinema.Common.Exceptions;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.EmailService
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;

        public EmailSender(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public async Task SendEmailAsync(IEnumerable<string> to, string subject, string content, IFormFileCollection attachments)
        {
            Message message = new Message(to, subject, content, attachments);

            await SendEmailAsync(message);
        }

        public async Task SendEmailAsync(IEnumerable<string> to, string subject, string content)
        {
            Message message = new Message(to, subject, content);

            await SendEmailAsync(message);
        }

        private void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);

            Send(emailMessage);
        }

        private async Task SendEmailAsync(Message message)
        {
            var mailMessage = CreateEmailMessage(message);

            await SendAsync(mailMessage);
        }

        private MimeMessage CreateEmailMessage(Message message)
        {


            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_emailConfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;

            //we replace body with bodyBuilder so we can include our attachment here                        

            if (message.Attachments != null && message.Attachments.Any())
            {
                var bodyBuilder = new BodyBuilder { HtmlBody = string.Format("{0}", message.Content) };

                byte[] fileBytes;
                foreach (var attachment in message.Attachments)
                {
                    using (var ms = new MemoryStream())
                    {
                        attachment.CopyTo(ms);
                        fileBytes = ms.ToArray();
                    }

                    bodyBuilder.Attachments.Add(attachment.FileName, fileBytes, ContentType.Parse(attachment.ContentType));
                }

                emailMessage.Body = bodyBuilder.ToMessageBody();
            }
            else
            {
                emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = string.Format("{0}", message.Content) };
            }

            return emailMessage;
        }

        private void Send(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {

                    //client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.CheckCertificateRevocation = false;
                    //client.SslProtocols |= SslProtocols.Tls;
                    /**
                     * setting the Connect third parameter to false (is secure) made the email to be sent.
                     * This should be a temporary fix
                     * 
                     * references:
                     * https://github.com/jstedfast/MailKit/blob/master/FAQ.md#SslHandshakeException
                     * https://github.com/jstedfast/MailKit/issues/735
                    */
                    client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, false);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_emailConfig.UserName, _emailConfig.Password);

                    client.Send(mailMessage);
                }
                catch
                {
                    //log an error message or throw an exception or both.
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }


        private async Task SendAsync(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, false);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    await client.AuthenticateAsync(_emailConfig.UserName, _emailConfig.Password);

                    await client.SendAsync(mailMessage);
                }
                catch (Exception ex)
                {
                    //log an error message or throw an exception, or both.
                    Console.WriteLine($"Error while sending the email. Error message: {ex.Message}");
                }
                finally
                {
                    await client.DisconnectAsync(true);
                    client.Dispose();
                }
            }
        }
    }
}
