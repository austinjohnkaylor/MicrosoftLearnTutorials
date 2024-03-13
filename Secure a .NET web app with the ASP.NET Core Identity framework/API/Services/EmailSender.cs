using API.Config;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace API.Services;

/// <summary>
/// Sends a confirmation email using SendGrid.
/// </summary>
/// <remarks>See https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-8.0&tabs=visual-studio</remarks>
public class EmailSender(
    IOptions<AuthMessageSenderOptions> optionsAccessor,
    ILogger<EmailSender> logger)
    : IEmailSender
{
    private readonly ILogger _logger = logger;

    public AuthMessageSenderOptions Options { get; } = optionsAccessor.Value; //Set with Secret Manager.

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        if (string.IsNullOrEmpty(Options.SendGridKey)) // Need to create a SendGrid key and add it to user-secrets
        {
            throw new Exception("Null SendGridKey");
        }
        await Execute(Options.SendGridKey, subject, message, toEmail);
    }

    public async Task Execute(string apiKey, string subject, string message, string toEmail)
    {
        SendGridClient client = new(apiKey);
        SendGridMessage msg = new()
        {
            From = new EmailAddress("Joe@contoso.com", "Password Recovery"),
            Subject = subject,
            PlainTextContent = message,
            HtmlContent = message
        };
        msg.AddTo(new EmailAddress(toEmail));

        // Disable click tracking.
        // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
        msg.SetClickTracking(false, false);
        Response? response = await client.SendEmailAsync(msg);
        _logger.LogInformation(response.IsSuccessStatusCode 
            ? $"Email to {toEmail} queued successfully!"
            : $"Failure Email to {toEmail}");
    }
}