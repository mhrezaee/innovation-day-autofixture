using AutoFixture;
using DemoApi.Models;
using FluentAssertions;

namespace DemoApi.Tests.ModelTests;

public class UserTests
{
    private readonly Fixture _fixture;

    public UserTests()
    {
        _fixture = new Fixture();
    }

    //when you need frozen data (register - inject)
    [Fact]
    public void ToString_Should_Return_FirstnameAndLastname_Manual()
    {
        //arrange
        var user = new User()
        {
            Id = Guid.NewGuid(),
            Lastname = "someLastName"
        };

        //act
        var res = user.ToString();

        //assert
        res.Should().Be($"{user.Id}-{user.Lastname}");
    }
    [Fact]
    public void ToString_Should_Return_FirstnameAndLastname_AutoFixture()
    {
        //arrange
        var id = _fixture.Freeze<Guid>();
        var lastName = _fixture.Freeze<string>();
        var user = _fixture.Create<User>();

        //act
        var res = user.ToString();

        //assert
        res.Should().Be($"{id}-{lastName}");
    }
}