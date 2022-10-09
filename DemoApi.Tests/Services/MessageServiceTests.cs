using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using DemoApi.Services;
using DemoApi.Tests.Infrastructure.Attributes;
using FluentAssertions;
using Moq;

namespace DemoApi.Tests.Services;

public class MessageServiceTests
{
    [Fact]
    public void Send_WithMoq()
    {

        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x=>x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();

    }

    [Fact]
    public void Send_WithAutoFixtureAutoMoq()
    {
        //arrange
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization());
        var sut = fixture.Create<MessageService>();

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        result.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public void Send_WithAutoFixtureAutoMoqAndAutoData(string address,string messageBody)
    {
        //arrange
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization());
        var sut = fixture.Create<MessageService>();

        //act
        var result = sut.Send(address, messageBody);

        //assert
        result.Should().BeTrue();

    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoq(string address, string messageBody, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        result.Should().BeTrue();
    }

    [Theory]
    [AutoData]
    public void Send_WithAutoFixtureAutoMoqAndAutoDataAndFreezeInterface(string address, string messageBody)
    {
        //arrange
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization());
        var mockGateway = fixture.Freeze<Mock<IMessageGateway>>();
        var sut = fixture.Create<MessageService>();

        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
}