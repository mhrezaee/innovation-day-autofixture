namespace DemoApi.Services;

public interface IMessageGateway
{
    void Send(string address, string body);
}