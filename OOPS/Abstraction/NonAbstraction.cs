namespace OOPS.Abstraction;

public class NonAbstraction : INonAbstraction
{
    //Email service in non-abstracted way
    // Here, if user needs to send an email, they want to create the instance of this class
    // And call these methods one-by-one in this specific order
    // Overhead and unneccessary
    public bool Connect()
    {
        Console.WriteLine("Connecting...");
        return true;
    }

    public bool Authenticate(string username, string password)
    {
        Console.WriteLine("Authenticating...");
        return true;
    }

    public bool SendMessage(string recipient,string subject, string messageBody)
    {
        Console.WriteLine("Sending message...");
        return true;
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting...");
    }
}