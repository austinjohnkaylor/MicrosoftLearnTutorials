namespace API.Config;

/// <summary>
/// Options for the AuthMessageSender.
/// </summary>
/// <remarks>See https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-8.0&tabs=visual-studio#configure-an-email-provider</remarks>
public class AuthMessageSenderOptions
{
    public string? SendGridKey { get; set; }
}