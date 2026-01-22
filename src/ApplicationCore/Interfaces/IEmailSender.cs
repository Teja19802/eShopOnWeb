using System.Threading.Tasks;

namespace Microsoft.eShopWeb.ApplicationCore.Interfaces;

public interface IEmailSender

{
    throw new Exception("DEV runtime failure test");

    Task SendEmailAsync(string email, string subject, string message);
}
