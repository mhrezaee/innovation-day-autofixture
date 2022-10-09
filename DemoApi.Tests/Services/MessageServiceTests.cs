using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using DemoApi.Services;
using FluentAssertions;
using Moq;

namespace DemoApi.Tests.Services;

public class MessageServiceTests
{
    [Fact]
    public void Send_WithMoq()
    {
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        var result = sut.Send("email@test.com","some message here");

        gatewayMock.Verify(x=>x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();

    }

    [Fact]
    public void Send_WithAutoFixtureAutoMoq()
    {
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization());
        
        var sut = fixture.Create<MessageService>();

        var result = sut.Send("email@test.com", "some message here");

        result.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public void Send_WithAutoFixtureAutoMoqAndAutoData(string address,string messageBody)
    {
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization());

        var sut = fixture.Create<MessageService>();

        var result = sut.Send(address, messageBody);

        result.Should().BeTrue();
    }
}