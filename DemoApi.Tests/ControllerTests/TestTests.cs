using AutoFixture.AutoMoq;
using AutoFixture;
using DemoApi.Controllers;
using DemoApi.Models;
using DemoApi.Tests.Helpers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace DemoApi.Tests.ControllerTests;

public class TestTests
{
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoMoq()
    {
        //arrange
        var fixture = new Fixture();
        fixture.Customize(new AutoMoqCustomization());
        var sut = fixture.Create<UserController>();
        var user = fixture.Create<User>();

        //act
        sut.Validate(user);
        var result = sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
}