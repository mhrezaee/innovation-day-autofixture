using AutoFixture.Xunit2;
using DemoApi.Services;
using DemoApi.Tests.Infrastructure.Attributes;
using FluentAssertions;
using Moq;

namespace DemoApi.Tests.ServiceTests;

public class MessagingService1000TestsWithAutoFixture
{
    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface0(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface1(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface2(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface3(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface4(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface5(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface6(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface7(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface8(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface9(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface10(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface11(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface12(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface13(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface14(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface15(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface16(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface17(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface18(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface19(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface20(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface21(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface22(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface23(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface24(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface25(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface26(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface27(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface28(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface29(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface30(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface31(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface32(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface33(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface34(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface35(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface36(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface37(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface38(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface39(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface40(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface41(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface42(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface43(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface44(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface45(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface46(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface47(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface48(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface49(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface50(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface51(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface52(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface53(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface54(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface55(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface56(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface57(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface58(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface59(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface60(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface61(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface62(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface63(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface64(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface65(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface66(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface67(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface68(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface69(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface70(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface71(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface72(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface73(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface74(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface75(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface76(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface77(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface78(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface79(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface80(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface81(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface82(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface83(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface84(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface85(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface86(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface87(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface88(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface89(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface90(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface91(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface92(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface93(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface94(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface95(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface96(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface97(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface98(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface99(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface100(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface101(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface102(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface103(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface104(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface105(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface106(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface107(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface108(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface109(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface110(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface111(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface112(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface113(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface114(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface115(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface116(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface117(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface118(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface119(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface120(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface121(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface122(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface123(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface124(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface125(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface126(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface127(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface128(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface129(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface130(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface131(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface132(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface133(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface134(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface135(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface136(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface137(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface138(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface139(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface140(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface141(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface142(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface143(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface144(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface145(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface146(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface147(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface148(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface149(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface150(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface151(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface152(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface153(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface154(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface155(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface156(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface157(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface158(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface159(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface160(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface161(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface162(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface163(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface164(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface165(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface166(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface167(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface168(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface169(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface170(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface171(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface172(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface173(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface174(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface175(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface176(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface177(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface178(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface179(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface180(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface181(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface182(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface183(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface184(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface185(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface186(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface187(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface188(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface189(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface190(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface191(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface192(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface193(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface194(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface195(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface196(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface197(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface198(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface199(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface200(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface201(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface202(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface203(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface204(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface205(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface206(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface207(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface208(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface209(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface210(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface211(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface212(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface213(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface214(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface215(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface216(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface217(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface218(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface219(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface220(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface221(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface222(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface223(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface224(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface225(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface226(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface227(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface228(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface229(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface230(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface231(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface232(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface233(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface234(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface235(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface236(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface237(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface238(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface239(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface240(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface241(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface242(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface243(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface244(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface245(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface246(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface247(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface248(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface249(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface250(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface251(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface252(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface253(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface254(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface255(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface256(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface257(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface258(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface259(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface260(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface261(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface262(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface263(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface264(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface265(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface266(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface267(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface268(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface269(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface270(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface271(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface272(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface273(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface274(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface275(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface276(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface277(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface278(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface279(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface280(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface281(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface282(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface283(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface284(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface285(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface286(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface287(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface288(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface289(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface290(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface291(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface292(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface293(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface294(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface295(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface296(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface297(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface298(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface299(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface300(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface301(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface302(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface303(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface304(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface305(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface306(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface307(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface308(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface309(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface310(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface311(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface312(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface313(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface314(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface315(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface316(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface317(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface318(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface319(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface320(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface321(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface322(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface323(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface324(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface325(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface326(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface327(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface328(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface329(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface330(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface331(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface332(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface333(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface334(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface335(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface336(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface337(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface338(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface339(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface340(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface341(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface342(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface343(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface344(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface345(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface346(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface347(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface348(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface349(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface350(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface351(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface352(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface353(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface354(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface355(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface356(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface357(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface358(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface359(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface360(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface361(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface362(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface363(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface364(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface365(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface366(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface367(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface368(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface369(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface370(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface371(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface372(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface373(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface374(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface375(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface376(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface377(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface378(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface379(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface380(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface381(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface382(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface383(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface384(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface385(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface386(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface387(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface388(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface389(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface390(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface391(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface392(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface393(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface394(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface395(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface396(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface397(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface398(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface399(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface400(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface401(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface402(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface403(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface404(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface405(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface406(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface407(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface408(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface409(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface410(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface411(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface412(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface413(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface414(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface415(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface416(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface417(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface418(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface419(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface420(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface421(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface422(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface423(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface424(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface425(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface426(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface427(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface428(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface429(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface430(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface431(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface432(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface433(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface434(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface435(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface436(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface437(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface438(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface439(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface440(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface441(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface442(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface443(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface444(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface445(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface446(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface447(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface448(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface449(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface450(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface451(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface452(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface453(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface454(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface455(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface456(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface457(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface458(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface459(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface460(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface461(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface462(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface463(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface464(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface465(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface466(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface467(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface468(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface469(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface470(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface471(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface472(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface473(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface474(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface475(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface476(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface477(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface478(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface479(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface480(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface481(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface482(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface483(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface484(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface485(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface486(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface487(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface488(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface489(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface490(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface491(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface492(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface493(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface494(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface495(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface496(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface497(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface498(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface499(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface500(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface501(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface502(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface503(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface504(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface505(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface506(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface507(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface508(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface509(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface510(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface511(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface512(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface513(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface514(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface515(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface516(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface517(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface518(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface519(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface520(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface521(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface522(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface523(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface524(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface525(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface526(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface527(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface528(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface529(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface530(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface531(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface532(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface533(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface534(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface535(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface536(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface537(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface538(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface539(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface540(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface541(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface542(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface543(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface544(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface545(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface546(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface547(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface548(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface549(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface550(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface551(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface552(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface553(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface554(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface555(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface556(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface557(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface558(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface559(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface560(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface561(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface562(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface563(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface564(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface565(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface566(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface567(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface568(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface569(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface570(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface571(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface572(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface573(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface574(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface575(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface576(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface577(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface578(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface579(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface580(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface581(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface582(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface583(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface584(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface585(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface586(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface587(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface588(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface589(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface590(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface591(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface592(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface593(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface594(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface595(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface596(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface597(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface598(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface599(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface600(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface601(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface602(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface603(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface604(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface605(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface606(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface607(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface608(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface609(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface610(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface611(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface612(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface613(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface614(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface615(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface616(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface617(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface618(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface619(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface620(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface621(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface622(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface623(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface624(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface625(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface626(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface627(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface628(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface629(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface630(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface631(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface632(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface633(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface634(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface635(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface636(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface637(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface638(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface639(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface640(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface641(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface642(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface643(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface644(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface645(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface646(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface647(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface648(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface649(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface650(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface651(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface652(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface653(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface654(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface655(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface656(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface657(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface658(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface659(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface660(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface661(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface662(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface663(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface664(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface665(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface666(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface667(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface668(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface669(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface670(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface671(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface672(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface673(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface674(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface675(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface676(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface677(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface678(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface679(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface680(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface681(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface682(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface683(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface684(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface685(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface686(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface687(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface688(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface689(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface690(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface691(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface692(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface693(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface694(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface695(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface696(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface697(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface698(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface699(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface700(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface701(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface702(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface703(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface704(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface705(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface706(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface707(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface708(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface709(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface710(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface711(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface712(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface713(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface714(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface715(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface716(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface717(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface718(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface719(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface720(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface721(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface722(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface723(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface724(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface725(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface726(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface727(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface728(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface729(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface730(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface731(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface732(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface733(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface734(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface735(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface736(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface737(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface738(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface739(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface740(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface741(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface742(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface743(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface744(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface745(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface746(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface747(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface748(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface749(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface750(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface751(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface752(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface753(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface754(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface755(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface756(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface757(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface758(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface759(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface760(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface761(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface762(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface763(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface764(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface765(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface766(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface767(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface768(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface769(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface770(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface771(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface772(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface773(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface774(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface775(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface776(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface777(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface778(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface779(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface780(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface781(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface782(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface783(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface784(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface785(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface786(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface787(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface788(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface789(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface790(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface791(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface792(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface793(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface794(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface795(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface796(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface797(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface798(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface799(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface800(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface801(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface802(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface803(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface804(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface805(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface806(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface807(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface808(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface809(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface810(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface811(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface812(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface813(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface814(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface815(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface816(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface817(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface818(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface819(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface820(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface821(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface822(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface823(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface824(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface825(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface826(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface827(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface828(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface829(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface830(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface831(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface832(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface833(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface834(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface835(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface836(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface837(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface838(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface839(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface840(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface841(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface842(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface843(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface844(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface845(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface846(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface847(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface848(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface849(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface850(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface851(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface852(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface853(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface854(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface855(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface856(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface857(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface858(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface859(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface860(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface861(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface862(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface863(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface864(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface865(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface866(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface867(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface868(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface869(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface870(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface871(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface872(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface873(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface874(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface875(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface876(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface877(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface878(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface879(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface880(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface881(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface882(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface883(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface884(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface885(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface886(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface887(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface888(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface889(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface890(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface891(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface892(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface893(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface894(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface895(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface896(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface897(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface898(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface899(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface900(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface901(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface902(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface903(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface904(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface905(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface906(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface907(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface908(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface909(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface910(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface911(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface912(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface913(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface914(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface915(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface916(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface917(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface918(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface919(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface920(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface921(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface922(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface923(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface924(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface925(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface926(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface927(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface928(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface929(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface930(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface931(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface932(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface933(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface934(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface935(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface936(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface937(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface938(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface939(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface940(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface941(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface942(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface943(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface944(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface945(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface946(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface947(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface948(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface949(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface950(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface951(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface952(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface953(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface954(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface955(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface956(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface957(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface958(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface959(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface960(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface961(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface962(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface963(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface964(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface965(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface966(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface967(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface968(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface969(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface970(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface971(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface972(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface973(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface974(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface975(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface976(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface977(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface978(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface979(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface980(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface981(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface982(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface983(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface984(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface985(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface986(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface987(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface988(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface989(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface990(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface991(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface992(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface993(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface994(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface995(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface996(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface997(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface998(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)
    {
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }

    [Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface999(string address, string messageBody
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