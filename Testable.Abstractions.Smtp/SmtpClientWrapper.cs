using System.Net;
using System.Net.Mail;
using Testable.Abstractions.Smtp.Models;

namespace Testable.Abstractions.Smtp;

public class SmtpClientWrapper : ISmtpClientWrapper
{
    public SmtpClientWrapper(SmtpOptions smtpOptions)
    {
        SmtpClient.Host = smtpOptions.Host;
        SmtpClient.Port = smtpOptions.Port;
        SmtpClient.UseDefaultCredentials = smtpOptions.UseDefaultCredentials;
        SmtpClient.Credentials = new NetworkCredential(smtpOptions.User, smtpOptions.Password);
        SmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
    }

    public SmtpClient SmtpClient { get; set; } = new SmtpClient() { EnableSsl = false };

    public async Task SendMailAsync(MailMessage message)
    {
        await SmtpClient.SendMailAsync(message);
    }
}
