using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Text;
using Xunit.Abstractions;

namespace DemoApi.Tests;

public class TestMethodGenerator
{
    private readonly ITestOutputHelper _output;

    public TestMethodGenerator(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void GenerateTestWithAutoFixture()
    {
        for (int i = 0; i < 1000; i++)
        {
            var method = new StringBuilder();
            method.Append($@"[Theory]
    [AutoMoqData]
    public void Send_WithAutoFixtureAutoMoqAndAutoMoqAndFreezeInterface{i}(string address, string messageBody
        , [Frozen] Mock<IMessageGateway> mockGateway, MessageService sut)");
            method.Append(@"{
        //arrange
        //act
        var result = sut.Send(address, messageBody);

        //assert
        mockGateway.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }");


            _output.WriteLine(method.ToString());
        }
    }

    [Fact]
    public void GenerateTestWithMoq()
    {
        for (int i = 0; i < 1000; i++)
        {
            var method = new StringBuilder();
            method.Append($@"[Fact]
    public void Send_WithMoq{i}()");
            method.Append(@"{
        //arrange
        var gatewayMock = new Mock<IMessageGateway>();
        var sut = new MessageService(gatewayMock.Object);

        //act
        var result = sut.Send(""email@test.com"", ""some message here"");

        //assert
        gatewayMock.Verify(x => x.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        result.Should().BeTrue();
    }");


            _output.WriteLine(method.ToString());
        }
    }


    [Fact]
    public void GenerateTestWithManualObjectCreation()
    {
        for (int i = 0; i < 1000; i++)
        {
            var method = new StringBuilder();
            method.Append($@"[Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture{i}()");
            method.Append(@"{
        //arrange
        var user = new User()
        {
            Id = Guid.NewGuid(),
            Email = ""test@test.com"",
            Firstname = ""some first name"",
            Lastname = ""some last name"",
            Password = ""12345"",
            ConfirmPassword = ""1234567"",
            AddressId = Guid.NewGuid(),
            Address = new Address()
            {
                Id = Guid.NewGuid(),
                City = ""Vienna"",
                CountryCode = ""AT"",
                PostalCode = ""1030"",
                Street = ""InvalidStrasse""
            }
        };

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }");


            _output.WriteLine(method.ToString());
        }
    }

    [Fact]
    public void GenerateTestCreateObjectWithAutoFixture()
    {
        for (int i = 0; i < 1000; i++)
        {
            var method = new StringBuilder();
            method.Append($@"[Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture{i}()");
            method.Append(@"{
        //arrange
        var user = _fixture.Create<User>();
        
        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }");
            _output.WriteLine(method.ToString());
        }
    }
}