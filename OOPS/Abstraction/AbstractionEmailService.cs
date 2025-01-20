namespace OOPS.Abstraction;

public class AbstractionEmailService
{
    public bool SendEmail(string email, string subject, string body)
    {
        //Connect
        Connect();
        
        //Authenticate
        Authenticate();
        
        //Sending an email
        Console.WriteLine($"Sending email to {email}");
        
        //Disconnect
        Disconnect();
        return true;
    }

    private bool Connect()
    {
        return true;
    }

    private bool Authenticate()
    {
        return true;
    }

    private void Disconnect()
    {
        Console.WriteLine("Disconnecting...");
    }
}