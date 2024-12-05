namespace Testable.Abstractions.Smtp.Models;

public class SmtpOptions
{
    public string From { get; set; } = null!;
    public string To { get; set; } = null!;
    public string Host { get; set; } = null!;
    public int Port { get; set; }
    public string User { get; set; } = null!;
    public string Password { get; set; } = null!;
    public bool UseDefaultCredentials { get; set; }
}
