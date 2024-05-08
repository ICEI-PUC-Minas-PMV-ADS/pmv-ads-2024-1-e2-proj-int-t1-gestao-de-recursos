using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Services;
public class NullEmailSenderService : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // Implementação vazia, não faz nada
        return Task.CompletedTask;
    }
}
