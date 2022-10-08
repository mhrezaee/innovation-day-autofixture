using System.Net.Mail;
using AutoFixture;
using Bogus;
using DemoApi.Controllers;
using DemoApi.Models;
using DemoApi.Tests.Helpers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit.Sdk;

namespace DemoApi.Tests.ControllerTests;

public class UserControllerTests
{
    private readonly UserController _sut;
    private readonly Fixture _fixture;
    private readonly Faker _faker;

    public UserControllerTests()
    {
        _sut = new UserController();
        _fixture = new Fixture();
        _faker = new Faker();
    }

    //note: when object has Required fields.
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture()
    {
        //arrange
        var user = new User()
        {
            Password = "123",
            ConfirmPassword = "ABC"
        };
        /*var user = new User()
        {
            Id = Guid.NewGuid(),
            Email = "test@test.com",
            Firstname = "some first name",
            Lastname = "some last name",
            Password = "12345",
            ConfirmPassword = "1234567",
            AddressId = Guid.NewGuid(),
            Address = new Address()
            {
                Id = Guid.NewGuid(),
                City = "Vienna",
                CountryCode = "AT",
                PostalCode = "1030",
                Street = "InvalidStrasse"
            }
        };
        */

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }


    //note: it never create unique data for same type!
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


    //define partially with builder pattern!
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture2()
    {
        //arrange
        var user = _fixture.Build<User>()
            .With(x => x.Password, "ABC")
            .With(x => x.ConfirmPassword, "ABCDF")
            .Create();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }

    //note: enable email RegEx in User Model
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixture3()
    {
        //arrange
        var user = _fixture.Build<User>()
            .With(x => x.Password, "ABC")
            .With(x => x.ConfirmPassword, "ABCDF")
            .With(x => x.Email, _fixture.Create<MailAddress>().Address)
            .Create();
        
        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }

    //note: enable email RegEx in User Model
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnBadRequestWithAutoFixtureAndBogus()
    {
        //arrange
        var user = _fixture.Build<User>()
            .With(x => x.Password, "ABC")
            .With(x => x.ConfirmPassword, "ABCDF")
            .With(x=>x.Email, _faker.Internet.Email())
            .Create();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }

    //use customize
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithAutoFixture4()
    {
        //customize section can be in more general section and just called here
        _fixture.Customize<Address>(u => 
            u.With(x=>x.CountryCode, "AT")
        );

        //arrange
        var user = _fixture.Build<User>()
            .With(x => x.Password, "ABC")
            .With(x => x.ConfirmPassword, "ABCDF")
            .With(x => x.Email, _fixture.Create<MailAddress>().Address)
            .Create();

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }


}