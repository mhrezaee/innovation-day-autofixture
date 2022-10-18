using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using BenchmarkDotNet.Attributes;
using DemoApi.Benchmark.Attributes;
using DemoApi.Benchmark.Services;
using Moq;
using Xunit;

namespace DemoApi.Benchmark;


[MemoryDiagnoser]
public class MockBenchMark
{
    [Benchmark]
    [Fact]
    public void Send_WithMoq()
    {

        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        
        //assert           

    }

    [Benchmark]
    [Fact]
    public void Send_WithAutoFixtureAutoMoq()
    {
        //arrange
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization());
        var sut = fixture.Create<MessageService>();

        //act
        
        //assert
    }
}