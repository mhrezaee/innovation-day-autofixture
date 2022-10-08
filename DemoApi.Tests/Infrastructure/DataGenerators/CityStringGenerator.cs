using System.Reflection;
using AutoFixture.Kernel;

namespace DemoApi.Tests.Infrastructure.DataGenerators;

public class CityStringGenerator : ISpecimenBuilder
{
    public object Create(object request, ISpecimenContext context)
    {
        if (request is not PropertyInfo propertyInfo)
        {
            return new NoSpecimen();
        }

        var isCountryCode = propertyInfo.Name.Contains("City");
        var isStringProperty = propertyInfo.PropertyType == typeof(string);

        if (isCountryCode && isStringProperty)
        {
            return "Vienna";
        }

        return new NoSpecimen();
    }
    
}