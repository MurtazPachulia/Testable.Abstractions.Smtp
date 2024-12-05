using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Testable.Abstractions.Smtp;

public interface ISmtpClientWrapper
{
    Task SendMailAsync(MailMessage message);
}
