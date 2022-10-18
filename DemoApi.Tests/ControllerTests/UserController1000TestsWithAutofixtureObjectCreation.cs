using AutoFixture;
using DemoApi.Controllers;
using DemoApi.Models;
using DemoApi.Tests.Helpers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Tests.ControllerTests;

public class UserController1000TestsWithAutofixtureObjectCreation
{
    private readonly UserController _sut;
    private readonly Fixture _fixture;

    public UserController1000TestsWithAutofixtureObjectCreation()
    {
        _sut = new UserController();
        _fixture = new Fixture();
    }

    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture0()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture1()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture2()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture3()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture4()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture5()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture6()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture7()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture8()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture9()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture10()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture11()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture12()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture13()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture14()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture15()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture16()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture17()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture18()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture19()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture20()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture21()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture22()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture23()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture24()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture25()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture26()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture27()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture28()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture29()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture30()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture31()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture32()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture33()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture34()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture35()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture36()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture37()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture38()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture39()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture40()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture41()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture42()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture43()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture44()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture45()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture46()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture47()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture48()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture49()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture50()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture51()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture52()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture53()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture54()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture55()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture56()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture57()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture58()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture59()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture60()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture61()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture62()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture63()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture64()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture65()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture66()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture67()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture68()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture69()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture70()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture71()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture72()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture73()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture74()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture75()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture76()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture77()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture78()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture79()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture80()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture81()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture82()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture83()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture84()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture85()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture86()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture87()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture88()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture89()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture90()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture91()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture92()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture93()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture94()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture95()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture96()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture97()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture98()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture99()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture100()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture101()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture102()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture103()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture104()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture105()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture106()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture107()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture108()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture109()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture110()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture111()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture112()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture113()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture114()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture115()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture116()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture117()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture118()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture119()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture120()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture121()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture122()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture123()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture124()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture125()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture126()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture127()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture128()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture129()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture130()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture131()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture132()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture133()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture134()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture135()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture136()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture137()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture138()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture139()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture140()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture141()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture142()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture143()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture144()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture145()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture146()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture147()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture148()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture149()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture150()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture151()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture152()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture153()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture154()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture155()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture156()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture157()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture158()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture159()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture160()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture161()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture162()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture163()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture164()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture165()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture166()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture167()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture168()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture169()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture170()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture171()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture172()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture173()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture174()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture175()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture176()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture177()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture178()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture179()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture180()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture181()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture182()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture183()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture184()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture185()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture186()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture187()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture188()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture189()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture190()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture191()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture192()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture193()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture194()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture195()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture196()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture197()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture198()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture199()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture200()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture201()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture202()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture203()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture204()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture205()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture206()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture207()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture208()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture209()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture210()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture211()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture212()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture213()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture214()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture215()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture216()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture217()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture218()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture219()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture220()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture221()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture222()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture223()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture224()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture225()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture226()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture227()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture228()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture229()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture230()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture231()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture232()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture233()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture234()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture235()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture236()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture237()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture238()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture239()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture240()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture241()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture242()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture243()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture244()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture245()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture246()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture247()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture248()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture249()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture250()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture251()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture252()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture253()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture254()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture255()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture256()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture257()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture258()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture259()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture260()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture261()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture262()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture263()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture264()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture265()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture266()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture267()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture268()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture269()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture270()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture271()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture272()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture273()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture274()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture275()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture276()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture277()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture278()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture279()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture280()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture281()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture282()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture283()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture284()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture285()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture286()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture287()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture288()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture289()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture290()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture291()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture292()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture293()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture294()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture295()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture296()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture297()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture298()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture299()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture300()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture301()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture302()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture303()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture304()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture305()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture306()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture307()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture308()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture309()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture310()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture311()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture312()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture313()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture314()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture315()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture316()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture317()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture318()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture319()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture320()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture321()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture322()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture323()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture324()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture325()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture326()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture327()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture328()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture329()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture330()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture331()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture332()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture333()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture334()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture335()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture336()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture337()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture338()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture339()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture340()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture341()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture342()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture343()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture344()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture345()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture346()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture347()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture348()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture349()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture350()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture351()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture352()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture353()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture354()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture355()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture356()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture357()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture358()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture359()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture360()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture361()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture362()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture363()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture364()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture365()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture366()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture367()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture368()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture369()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture370()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture371()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture372()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture373()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture374()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture375()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture376()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture377()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture378()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture379()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture380()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture381()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture382()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture383()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture384()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture385()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture386()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture387()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture388()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture389()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture390()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture391()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture392()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture393()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture394()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture395()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture396()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture397()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture398()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture399()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture400()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture401()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture402()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture403()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture404()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture405()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture406()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture407()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture408()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture409()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture410()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture411()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture412()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture413()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture414()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture415()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture416()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture417()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture418()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture419()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture420()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture421()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture422()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture423()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture424()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture425()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture426()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture427()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture428()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture429()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture430()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture431()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture432()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture433()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture434()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture435()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture436()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture437()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture438()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture439()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture440()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture441()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture442()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture443()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture444()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture445()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture446()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture447()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture448()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture449()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture450()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture451()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture452()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture453()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture454()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture455()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture456()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture457()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture458()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture459()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture460()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture461()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture462()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture463()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture464()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture465()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture466()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture467()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture468()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture469()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture470()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture471()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture472()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture473()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture474()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture475()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture476()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture477()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture478()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture479()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture480()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture481()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture482()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture483()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture484()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture485()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture486()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture487()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture488()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture489()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture490()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture491()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture492()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture493()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture494()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture495()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture496()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture497()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture498()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture499()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture500()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture501()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture502()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture503()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture504()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture505()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture506()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture507()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture508()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture509()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture510()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture511()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture512()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture513()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture514()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture515()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture516()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture517()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture518()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture519()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture520()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture521()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture522()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture523()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture524()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture525()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture526()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture527()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture528()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture529()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture530()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture531()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture532()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture533()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture534()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture535()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture536()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture537()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture538()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture539()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture540()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture541()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture542()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture543()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture544()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture545()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture546()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture547()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture548()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture549()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture550()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture551()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture552()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture553()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture554()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture555()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture556()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture557()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture558()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture559()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture560()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture561()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture562()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture563()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture564()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture565()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture566()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture567()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture568()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture569()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture570()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture571()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture572()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture573()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture574()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture575()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture576()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture577()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture578()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture579()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture580()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture581()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture582()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture583()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture584()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture585()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture586()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture587()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture588()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture589()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture590()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture591()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture592()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture593()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture594()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture595()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture596()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture597()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture598()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture599()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture600()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture601()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture602()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture603()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture604()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture605()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture606()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture607()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture608()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture609()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture610()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture611()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture612()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture613()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture614()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture615()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture616()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture617()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture618()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture619()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture620()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture621()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture622()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture623()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture624()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture625()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture626()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture627()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture628()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture629()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture630()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture631()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture632()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture633()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture634()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture635()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture636()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture637()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture638()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture639()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture640()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture641()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture642()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture643()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture644()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture645()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture646()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture647()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture648()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture649()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture650()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture651()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture652()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture653()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture654()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture655()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture656()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture657()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture658()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture659()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture660()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture661()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture662()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture663()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture664()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture665()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture666()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture667()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture668()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture669()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture670()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture671()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture672()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture673()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture674()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture675()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture676()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture677()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture678()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture679()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture680()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture681()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture682()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture683()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture684()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture685()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture686()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture687()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture688()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture689()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture690()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture691()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture692()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture693()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture694()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture695()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture696()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture697()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture698()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture699()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture700()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture701()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture702()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture703()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture704()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture705()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture706()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture707()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture708()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture709()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture710()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture711()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture712()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture713()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture714()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture715()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture716()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture717()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture718()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture719()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture720()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture721()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture722()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture723()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture724()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture725()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture726()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture727()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture728()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture729()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture730()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture731()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture732()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture733()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture734()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture735()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture736()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture737()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture738()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture739()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture740()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture741()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture742()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture743()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture744()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture745()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture746()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture747()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture748()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture749()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture750()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture751()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture752()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture753()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture754()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture755()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture756()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture757()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture758()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture759()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture760()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture761()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture762()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture763()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture764()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture765()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture766()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture767()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture768()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture769()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture770()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture771()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture772()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture773()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture774()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture775()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture776()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture777()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture778()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture779()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture780()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture781()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture782()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture783()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture784()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture785()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture786()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture787()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture788()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture789()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture790()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture791()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture792()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture793()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture794()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture795()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture796()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture797()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture798()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture799()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture800()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture801()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture802()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture803()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture804()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture805()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture806()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture807()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture808()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture809()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture810()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture811()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture812()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture813()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture814()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture815()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture816()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture817()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture818()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture819()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture820()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture821()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture822()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture823()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture824()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture825()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture826()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture827()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture828()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture829()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture830()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture831()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture832()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture833()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture834()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture835()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture836()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture837()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture838()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture839()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture840()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture841()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture842()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture843()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture844()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture845()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture846()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture847()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture848()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture849()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture850()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture851()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture852()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture853()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture854()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture855()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture856()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture857()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture858()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture859()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture860()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture861()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture862()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture863()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture864()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture865()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture866()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture867()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture868()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture869()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture870()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture871()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture872()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture873()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture874()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture875()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture876()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture877()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture878()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture879()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture880()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture881()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture882()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture883()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture884()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture885()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture886()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture887()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture888()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture889()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture890()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture891()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture892()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture893()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture894()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture895()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture896()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture897()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture898()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture899()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture900()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture901()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture902()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture903()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture904()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture905()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture906()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture907()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture908()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture909()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture910()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture911()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture912()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture913()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture914()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture915()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture916()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture917()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture918()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture919()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture920()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture921()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture922()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture923()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture924()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture925()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture926()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture927()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture928()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture929()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture930()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture931()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture932()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture933()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture934()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture935()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture936()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture937()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture938()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture939()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture940()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture941()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture942()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture943()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture944()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture945()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture946()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture947()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture948()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture949()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture950()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture951()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture952()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture953()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture954()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture955()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture956()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture957()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture958()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture959()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture960()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture961()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture962()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture963()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture964()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture965()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture966()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture967()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture968()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture969()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture970()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture971()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture972()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture973()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture974()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture975()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture976()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture977()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture978()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture979()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture980()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture981()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture982()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture983()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture984()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture985()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture986()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture987()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture988()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture989()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture990()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture991()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture992()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture993()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture994()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture995()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture996()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture997()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture998()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture999()
    {
        //arrange
        var user = _fixture.Create<User>();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }

}