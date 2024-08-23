using HR_Management.Application.Contracts.Infrastructure;
using HR_Management.Application.Models;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Infrastructure.Mail
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSetting _emailSetting;
        public EmailSender(IOptions<EmailSetting> emailSetting)
        {
            _emailSetting = emailSetting.Value;
        }
        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(_emailSetting.ApiKey);
            var To=new EmailAddress(email.To);
            var From = new EmailAddress
            {
                Email = _emailSetting.FromAddress,
                Name = _emailSetting.FromName,
            };
            var message=MailHelper.CreateSingleEmail(From,To,email.Subject,email.Body,email.Body);
            var response=await client.SendEmailAsync(message);

            return response.StatusCode==System.Net.HttpStatusCode.OK||response.StatusCode==System.Net.HttpStatusCode.Accepted;
        }
    }
}
