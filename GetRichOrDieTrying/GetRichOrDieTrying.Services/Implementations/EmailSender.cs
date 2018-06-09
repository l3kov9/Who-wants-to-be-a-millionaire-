namespace GetRichOrDieTrying.Services.Implementations
{
    using System.Threading.Tasks;
    using Contracts;
    
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
