using AutoFixture;
using AutoFixture.AutoMoq;
using BenchmarkDotNet.Attributes;
using DemoApi.Benchmark.Services;
using Moq;

namespace DemoApi.Benchmark;


[MemoryDiagnoser]
public class MockBenchMark
{
    [Benchmark]
    public void Test_WithMoq()
    {

        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        
        //assert           

    }

    [Benchmark]
    public void Test_WithAutoFixtureAutoMoq()
    {
        //arrange
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization());
        var sut = fixture.Create<MessageService>();

        //act
        
        //assert
    }
}