using DemoApi.Controllers;
using DemoApi.Models;
using DemoApi.Tests.Helpers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Tests.ControllerTests;

public class UserController1000TestsWithManualObjectCreation
{
    private readonly UserController _sut;

    public UserController1000TestsWithManualObjectCreation()
    {
        _sut = new UserController();
    }

    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture0()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture1()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture2()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture3()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture4()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture5()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture6()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture7()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture8()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture9()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture10()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture11()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture12()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture13()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture14()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture15()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture16()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture17()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture18()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture19()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture20()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture21()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture22()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture23()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture24()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture25()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture26()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture27()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture28()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture29()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture30()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture31()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture32()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture33()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture34()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture35()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture36()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture37()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture38()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture39()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture40()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture41()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture42()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture43()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture44()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture45()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture46()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture47()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture48()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture49()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture50()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture51()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture52()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture53()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture54()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture55()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture56()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture57()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture58()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture59()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture60()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture61()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture62()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture63()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture64()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture65()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture66()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture67()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture68()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture69()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture70()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture71()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture72()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture73()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture74()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture75()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture76()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture77()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture78()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture79()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture80()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture81()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture82()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture83()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture84()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture85()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture86()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture87()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture88()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture89()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture90()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture91()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture92()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture93()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture94()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture95()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture96()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture97()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture98()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture99()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture100()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture101()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture102()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture103()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture104()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture105()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture106()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture107()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture108()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture109()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture110()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture111()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture112()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture113()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture114()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture115()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture116()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture117()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture118()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture119()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture120()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture121()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture122()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture123()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture124()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture125()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture126()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture127()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture128()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture129()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture130()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture131()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture132()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture133()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture134()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture135()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture136()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture137()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture138()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture139()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture140()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture141()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture142()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture143()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture144()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture145()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture146()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture147()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture148()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture149()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture150()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture151()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture152()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture153()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture154()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture155()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture156()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture157()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture158()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture159()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture160()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture161()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture162()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture163()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture164()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture165()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture166()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture167()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture168()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture169()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture170()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture171()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture172()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture173()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture174()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture175()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture176()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture177()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture178()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture179()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture180()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture181()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture182()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture183()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture184()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture185()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture186()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture187()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture188()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture189()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture190()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture191()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture192()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture193()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture194()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture195()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture196()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture197()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture198()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture199()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture200()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture201()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture202()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture203()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture204()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture205()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture206()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture207()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture208()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture209()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture210()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture211()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture212()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture213()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture214()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture215()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture216()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture217()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture218()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture219()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture220()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture221()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture222()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture223()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture224()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture225()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture226()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture227()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture228()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture229()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture230()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture231()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture232()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture233()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture234()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture235()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture236()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture237()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture238()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture239()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture240()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture241()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture242()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture243()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture244()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture245()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture246()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture247()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture248()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture249()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture250()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture251()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture252()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture253()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture254()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture255()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture256()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture257()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture258()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture259()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture260()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture261()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture262()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture263()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture264()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture265()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture266()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture267()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture268()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture269()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture270()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture271()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture272()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture273()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture274()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture275()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture276()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture277()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture278()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture279()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture280()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture281()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture282()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture283()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture284()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture285()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture286()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture287()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture288()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture289()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture290()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture291()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture292()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture293()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture294()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture295()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture296()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture297()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture298()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture299()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture300()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture301()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture302()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture303()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture304()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture305()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture306()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture307()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture308()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture309()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture310()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture311()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture312()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture313()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture314()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture315()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture316()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture317()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture318()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture319()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture320()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture321()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture322()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture323()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture324()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture325()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture326()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture327()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture328()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture329()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture330()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture331()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture332()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture333()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture334()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture335()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture336()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture337()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture338()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture339()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture340()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture341()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture342()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture343()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture344()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture345()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture346()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture347()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture348()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture349()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture350()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture351()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture352()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture353()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture354()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture355()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture356()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture357()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture358()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture359()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture360()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture361()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture362()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture363()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture364()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture365()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture366()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture367()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture368()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture369()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture370()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture371()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture372()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture373()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture374()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture375()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture376()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture377()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture378()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture379()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture380()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture381()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture382()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture383()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture384()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture385()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture386()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture387()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture388()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture389()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture390()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture391()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture392()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture393()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture394()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture395()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture396()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture397()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture398()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture399()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture400()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture401()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture402()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture403()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture404()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture405()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture406()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture407()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture408()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture409()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture410()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture411()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture412()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture413()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture414()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture415()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture416()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture417()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture418()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture419()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture420()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture421()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture422()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture423()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture424()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture425()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture426()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture427()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture428()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture429()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture430()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture431()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture432()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture433()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture434()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture435()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture436()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture437()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture438()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture439()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture440()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture441()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture442()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture443()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture444()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture445()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture446()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture447()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture448()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture449()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture450()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture451()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture452()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture453()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture454()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture455()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture456()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture457()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture458()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture459()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture460()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture461()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture462()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture463()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture464()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture465()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture466()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture467()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture468()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture469()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture470()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture471()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture472()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture473()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture474()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture475()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture476()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture477()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture478()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture479()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture480()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture481()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture482()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture483()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture484()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture485()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture486()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture487()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture488()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture489()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture490()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture491()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture492()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture493()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture494()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture495()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture496()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture497()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture498()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture499()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture500()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture501()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture502()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture503()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture504()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture505()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture506()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture507()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture508()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture509()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture510()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture511()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture512()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture513()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture514()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture515()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture516()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture517()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture518()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture519()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture520()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture521()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture522()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture523()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture524()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture525()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture526()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture527()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture528()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture529()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture530()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture531()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture532()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture533()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture534()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture535()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture536()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture537()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture538()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture539()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture540()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture541()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture542()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture543()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture544()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture545()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture546()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture547()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture548()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture549()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture550()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture551()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture552()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture553()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture554()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture555()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture556()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture557()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture558()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture559()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture560()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture561()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture562()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture563()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture564()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture565()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture566()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture567()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture568()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture569()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture570()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture571()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture572()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture573()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture574()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture575()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture576()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture577()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture578()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture579()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture580()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture581()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture582()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture583()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture584()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture585()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture586()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture587()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture588()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture589()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture590()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture591()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture592()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture593()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture594()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture595()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture596()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture597()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture598()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture599()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture600()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture601()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture602()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture603()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture604()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture605()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture606()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture607()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture608()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture609()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture610()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture611()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture612()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture613()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture614()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture615()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture616()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture617()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture618()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture619()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture620()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture621()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture622()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture623()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture624()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture625()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture626()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture627()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture628()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture629()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture630()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture631()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture632()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture633()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture634()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture635()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture636()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture637()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture638()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture639()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture640()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture641()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture642()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture643()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture644()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture645()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture646()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture647()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture648()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture649()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture650()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture651()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture652()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture653()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture654()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture655()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture656()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture657()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture658()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture659()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture660()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture661()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture662()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture663()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture664()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture665()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture666()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture667()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture668()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture669()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture670()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture671()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture672()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture673()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture674()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture675()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture676()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture677()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture678()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture679()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture680()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture681()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture682()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture683()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture684()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture685()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture686()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture687()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture688()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture689()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture690()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture691()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture692()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture693()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture694()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture695()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture696()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture697()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture698()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture699()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture700()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture701()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture702()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture703()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture704()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture705()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture706()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture707()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture708()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture709()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture710()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture711()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture712()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture713()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture714()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture715()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture716()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture717()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture718()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture719()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture720()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture721()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture722()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture723()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture724()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture725()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture726()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture727()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture728()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture729()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture730()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture731()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture732()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture733()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture734()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture735()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture736()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture737()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture738()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture739()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture740()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture741()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture742()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture743()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture744()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture745()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture746()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture747()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture748()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture749()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture750()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture751()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture752()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture753()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture754()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture755()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture756()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture757()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture758()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture759()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture760()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture761()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture762()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture763()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture764()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture765()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture766()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture767()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture768()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture769()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture770()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture771()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture772()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture773()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture774()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture775()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture776()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture777()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture778()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture779()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture780()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture781()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture782()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture783()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture784()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture785()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture786()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture787()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture788()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture789()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture790()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture791()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture792()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture793()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture794()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture795()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture796()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture797()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture798()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture799()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture800()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture801()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture802()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture803()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture804()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture805()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture806()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture807()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture808()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture809()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture810()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture811()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture812()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture813()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture814()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture815()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture816()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture817()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture818()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture819()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture820()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture821()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture822()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture823()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture824()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture825()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture826()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture827()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture828()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture829()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture830()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture831()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture832()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture833()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture834()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture835()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture836()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture837()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture838()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture839()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture840()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture841()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture842()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture843()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture844()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture845()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture846()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture847()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture848()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture849()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture850()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture851()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture852()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture853()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture854()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture855()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture856()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture857()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture858()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture859()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture860()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture861()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture862()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture863()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture864()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture865()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture866()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture867()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture868()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture869()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture870()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture871()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture872()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture873()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture874()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture875()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture876()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture877()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture878()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture879()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture880()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture881()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture882()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture883()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture884()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture885()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture886()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture887()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture888()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture889()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture890()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture891()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture892()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture893()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture894()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture895()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture896()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture897()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture898()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture899()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture900()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture901()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture902()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture903()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture904()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture905()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture906()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture907()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture908()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture909()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture910()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture911()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture912()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture913()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture914()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture915()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture916()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture917()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture918()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture919()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture920()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture921()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture922()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture923()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture924()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture925()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture926()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture927()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture928()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture929()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture930()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture931()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture932()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture933()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture934()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture935()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture936()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture937()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture938()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture939()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture940()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture941()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture942()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture943()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture944()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture945()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture946()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture947()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture948()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture949()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture950()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture951()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture952()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture953()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture954()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture955()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture956()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture957()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture958()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture959()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture960()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture961()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture962()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture963()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture964()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture965()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture966()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture967()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture968()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture969()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture970()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture971()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture972()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture973()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture974()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture975()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture976()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture977()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture978()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture979()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture980()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture981()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture982()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture983()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture984()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture985()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture986()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture987()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture988()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture989()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture990()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture991()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture992()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture993()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture994()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture995()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture996()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture997()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture998()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }
    [Fact]
    public void Post_WhenPasswordDoesNotMatch_ShouldReturnForbiddenWithoutAutoFixture999()
    {
        //arrange
        var user = new User()
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

        //act
        _sut.Validate(user);
        var result = _sut.Post(user);

        //assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }

}