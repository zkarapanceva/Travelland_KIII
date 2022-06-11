using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Travelland.Domain.DomainModels;

namespace Travelland.Services.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(List<EmailMessage> allMails);
    }
}
