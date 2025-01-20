namespace OOPS.Abstraction;

public interface INonAbstraction
{
    bool Connect();
    bool Authenticate(string username, string password);
    bool SendMessage(string recipient, string messageBody);
    void Disconnect();
}