using AutoFixture;
using DemoApi.Models;
using DemoApi.Tests.Infrastructure.DataGenerators;
using FluentAssertions;

namespace DemoApi.Tests.ModelTests;

public class AddressTests
{
    private readonly Fixture _fixture;

    public AddressTests()
    {
        _fixture = new Fixture();
    }

    [Fact]
    public void Address_WithManualCustomization()
    {
        //arrange
        _fixture.Customize<Address>(u =>
            u.With(x => x.CountryCode, "AT")
        );

        //act
        var address = _fixture.Create<Address>();

        //assert
        address.CountryCode.Should().Be("AT");
    }

    [Fact]
    public void Address_WithSpecimenCustomization()
    {
        //arrange
        _fixture.Customizations.Add(new CityStringGenerator());

        //act
        var addresses = _fixture.CreateMany<Address>(6);
       

        //assert
        addresses.Should().OnlyContain(x => x.City == "Vienna");
    }
}