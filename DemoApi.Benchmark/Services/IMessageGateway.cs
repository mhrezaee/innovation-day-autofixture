namespace DemoApi.Benchmark.Services;

public interface IMessageGateway
{
    void Send(string address, string body);
}