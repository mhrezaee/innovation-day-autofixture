namespace DemoApi.Services;

public class MessageService
{
    private readonly IMessageGateway _gateway;

    public MessageService(IMessageGateway gateway)
    {
        _gateway = gateway;
    }


    public bool Send(string address, string messageBody)
    {
        try
        {
            _gateway.Send(address, messageBody);
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }
}