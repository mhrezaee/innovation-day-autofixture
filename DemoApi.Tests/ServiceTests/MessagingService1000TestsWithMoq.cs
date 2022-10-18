using DemoApi.Services;
using FluentAssertions;
using Moq;
namespace DemoApi.Tests.ServiceTests;

public class MessagingService1000TestsWithMoq
{
[Fact]
    public void Send_WithMoq0()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq1()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq2()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq3()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq4()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq5()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq6()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq7()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq8()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq9()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq10()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq11()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq12()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq13()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq14()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq15()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq16()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq17()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq18()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq19()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq20()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq21()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq22()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq23()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq24()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq25()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq26()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq27()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq28()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq29()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq30()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq31()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq32()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq33()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq34()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq35()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq36()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq37()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq38()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq39()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq40()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq41()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq42()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq43()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq44()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq45()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq46()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq47()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq48()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq49()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq50()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq51()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq52()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq53()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq54()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq55()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq56()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq57()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq58()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq59()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq60()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq61()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq62()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq63()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq64()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq65()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq66()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq67()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq68()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq69()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq70()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq71()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq72()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq73()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq74()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq75()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq76()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq77()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq78()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq79()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq80()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq81()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq82()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq83()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq84()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq85()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq86()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq87()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq88()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq89()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq90()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq91()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq92()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq93()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq94()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq95()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq96()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq97()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq98()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq99()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq100()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq101()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq102()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq103()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq104()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq105()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq106()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq107()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq108()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq109()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq110()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq111()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq112()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq113()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq114()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq115()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq116()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq117()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq118()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq119()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq120()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq121()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq122()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq123()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq124()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq125()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq126()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq127()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq128()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq129()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq130()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq131()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq132()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq133()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq134()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq135()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq136()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq137()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq138()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq139()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq140()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq141()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq142()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq143()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq144()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq145()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq146()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq147()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq148()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq149()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq150()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq151()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq152()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq153()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq154()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq155()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq156()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq157()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq158()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq159()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq160()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq161()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq162()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq163()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq164()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq165()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq166()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq167()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq168()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq169()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq170()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq171()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq172()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq173()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq174()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq175()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq176()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq177()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq178()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq179()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq180()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq181()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq182()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq183()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq184()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq185()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq186()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq187()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq188()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq189()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq190()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq191()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq192()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq193()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq194()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq195()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq196()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq197()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq198()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq199()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq200()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq201()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq202()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq203()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq204()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq205()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq206()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq207()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq208()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq209()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq210()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq211()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq212()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq213()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq214()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq215()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq216()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq217()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq218()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq219()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq220()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq221()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq222()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq223()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq224()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq225()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq226()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq227()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq228()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq229()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq230()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq231()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq232()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq233()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq234()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq235()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq236()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq237()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq238()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq239()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq240()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq241()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq242()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq243()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq244()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq245()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq246()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq247()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq248()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq249()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq250()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq251()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq252()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq253()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq254()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq255()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq256()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq257()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq258()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq259()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq260()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq261()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq262()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq263()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq264()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq265()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq266()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq267()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq268()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq269()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq270()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq271()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq272()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq273()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq274()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq275()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq276()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq277()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq278()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq279()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq280()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq281()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq282()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq283()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq284()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq285()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq286()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq287()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq288()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq289()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq290()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq291()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq292()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq293()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq294()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq295()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq296()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq297()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq298()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq299()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq300()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq301()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq302()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq303()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq304()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq305()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq306()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq307()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq308()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq309()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq310()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq311()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq312()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq313()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq314()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq315()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq316()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq317()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq318()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq319()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq320()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq321()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq322()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq323()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq324()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq325()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq326()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq327()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq328()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq329()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq330()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq331()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq332()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq333()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq334()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq335()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq336()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq337()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq338()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq339()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq340()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq341()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq342()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq343()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq344()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq345()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq346()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq347()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq348()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq349()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq350()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq351()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq352()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq353()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq354()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq355()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq356()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq357()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq358()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq359()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq360()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq361()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq362()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq363()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq364()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq365()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq366()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq367()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq368()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq369()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq370()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq371()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq372()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq373()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq374()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq375()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq376()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq377()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq378()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq379()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq380()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq381()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq382()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq383()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq384()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq385()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq386()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq387()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq388()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq389()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq390()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq391()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq392()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq393()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq394()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq395()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq396()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq397()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq398()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq399()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq400()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq401()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq402()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq403()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq404()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq405()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq406()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq407()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq408()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq409()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq410()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq411()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq412()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq413()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq414()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq415()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq416()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq417()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq418()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq419()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq420()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq421()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq422()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq423()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq424()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq425()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq426()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq427()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq428()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq429()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq430()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq431()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq432()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq433()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq434()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq435()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq436()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq437()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq438()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq439()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq440()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq441()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq442()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq443()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq444()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq445()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq446()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq447()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq448()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq449()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq450()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq451()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq452()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq453()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq454()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq455()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq456()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq457()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq458()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq459()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq460()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq461()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq462()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq463()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq464()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq465()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq466()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq467()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq468()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq469()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq470()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq471()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq472()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq473()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq474()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq475()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq476()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq477()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq478()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq479()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq480()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq481()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq482()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq483()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq484()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq485()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq486()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq487()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq488()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq489()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq490()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq491()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq492()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq493()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq494()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq495()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq496()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq497()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq498()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq499()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq500()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq501()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq502()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq503()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq504()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq505()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq506()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq507()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq508()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq509()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq510()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq511()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq512()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq513()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq514()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq515()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq516()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq517()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq518()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq519()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq520()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq521()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq522()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq523()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq524()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq525()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq526()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq527()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq528()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq529()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq530()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq531()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq532()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq533()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq534()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq535()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq536()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq537()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq538()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq539()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq540()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq541()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq542()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq543()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq544()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq545()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq546()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq547()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq548()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq549()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq550()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq551()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq552()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq553()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq554()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq555()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq556()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq557()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq558()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq559()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq560()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq561()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq562()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq563()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq564()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq565()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq566()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq567()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq568()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq569()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq570()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq571()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq572()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq573()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq574()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq575()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq576()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq577()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq578()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq579()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq580()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq581()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq582()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq583()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq584()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq585()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq586()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq587()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq588()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq589()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq590()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq591()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq592()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq593()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq594()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq595()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq596()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq597()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq598()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq599()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq600()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq601()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq602()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq603()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq604()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq605()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq606()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq607()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq608()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq609()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq610()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq611()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq612()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq613()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq614()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq615()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq616()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq617()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq618()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq619()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq620()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq621()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq622()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq623()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq624()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq625()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq626()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq627()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq628()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq629()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq630()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq631()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq632()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq633()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq634()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq635()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq636()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq637()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq638()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq639()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq640()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq641()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq642()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq643()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq644()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq645()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq646()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq647()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq648()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq649()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq650()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq651()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq652()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq653()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq654()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq655()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq656()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq657()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq658()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq659()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq660()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq661()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq662()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq663()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq664()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq665()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq666()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq667()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq668()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq669()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq670()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq671()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq672()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq673()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq674()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq675()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq676()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq677()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq678()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq679()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq680()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq681()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq682()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq683()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq684()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq685()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq686()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq687()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq688()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq689()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq690()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq691()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq692()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq693()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq694()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq695()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq696()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq697()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq698()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq699()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq700()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq701()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq702()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq703()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq704()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq705()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq706()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq707()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq708()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq709()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq710()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq711()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq712()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq713()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq714()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq715()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq716()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq717()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq718()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq719()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq720()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq721()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq722()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq723()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq724()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq725()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq726()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq727()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq728()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq729()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq730()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq731()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq732()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq733()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq734()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq735()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq736()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq737()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq738()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq739()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq740()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq741()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq742()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq743()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq744()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq745()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq746()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq747()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq748()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq749()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq750()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq751()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq752()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq753()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq754()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq755()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq756()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq757()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq758()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq759()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq760()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq761()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq762()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq763()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq764()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq765()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq766()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq767()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq768()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq769()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq770()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq771()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq772()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq773()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq774()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq775()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq776()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq777()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq778()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq779()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq780()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq781()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq782()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq783()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq784()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq785()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq786()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq787()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq788()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq789()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq790()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq791()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq792()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq793()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq794()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq795()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq796()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq797()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq798()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq799()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq800()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq801()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq802()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq803()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq804()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq805()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq806()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq807()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq808()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq809()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq810()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq811()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq812()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq813()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq814()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq815()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq816()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq817()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq818()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq819()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq820()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq821()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq822()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq823()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq824()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq825()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq826()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq827()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq828()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq829()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq830()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq831()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq832()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq833()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq834()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq835()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq836()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq837()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq838()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq839()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq840()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq841()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq842()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq843()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq844()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq845()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq846()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq847()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq848()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq849()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq850()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq851()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq852()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq853()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq854()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq855()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq856()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq857()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq858()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq859()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq860()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq861()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq862()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq863()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq864()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq865()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq866()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq867()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq868()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq869()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq870()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq871()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq872()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq873()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq874()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq875()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq876()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq877()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq878()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq879()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq880()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq881()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq882()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq883()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq884()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq885()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq886()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq887()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq888()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq889()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq890()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq891()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq892()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq893()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq894()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq895()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq896()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq897()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq898()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq899()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq900()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq901()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq902()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq903()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq904()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq905()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq906()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq907()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq908()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq909()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq910()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq911()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq912()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq913()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq914()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq915()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq916()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq917()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq918()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq919()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq920()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq921()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq922()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq923()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq924()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq925()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq926()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq927()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq928()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq929()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq930()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq931()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq932()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq933()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq934()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq935()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq936()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq937()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq938()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq939()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq940()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq941()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq942()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq943()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq944()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq945()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq946()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq947()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq948()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq949()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq950()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq951()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq952()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq953()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq954()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq955()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq956()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq957()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq958()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq959()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq960()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq961()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq962()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq963()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq964()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq965()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq966()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq967()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq968()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq969()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq970()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq971()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq972()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq973()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq974()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq975()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq976()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq977()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq978()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq979()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq980()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq981()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq982()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq983()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq984()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq985()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq986()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq987()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq988()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq989()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq990()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq991()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq992()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq993()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq994()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq995()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq996()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq997()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq998()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }
    [Fact]
    public void Send_WithMoq999()
    {
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send("email@test.com", "some message here");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

}