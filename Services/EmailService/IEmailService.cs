namespace BasicMailServiceAPI.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(Email request);
    }
}
