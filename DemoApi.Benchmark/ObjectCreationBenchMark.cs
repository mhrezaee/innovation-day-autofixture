using AutoFixture;
using BenchmarkDotNet.Attributes;

namespace DemoApi.Benchmark;


[MemoryDiagnoser]
public class BenchmarkTests
{
    
    [Benchmark]
    public List<Employee> Test_100_Manual_Objects()
    {
        var employees = new List<Employee>();

        for (var i = 0; i < 100; i++)
        {
            var employee = new Employee()
            {
                Id = 2,
                Birthday = DateTime.Now,
                Gender = Gender.Female,
                Name = "some name",
                Lastname = "some last name",
                Addresses = new List<Address>()
                {
                    new Address(){Id = Guid.NewGuid(), AddressType = AddressType.Home, Country = "some where", Street = "some street", ZipCode = "some zip code"},
                    new Address(){Id = Guid.NewGuid(), AddressType = AddressType.Home, Country = "some where", Street = "some street", ZipCode = "some zip code"},
                    new Address(){Id = Guid.NewGuid(), AddressType = AddressType.Home, Country = "some where", Street = "some street", ZipCode = "some zip code"}
                },
                Department = new Department()
                {
                    Id = Guid.NewGuid(),
                    Name = "dep name",
                    Sections = new List<Section>()
                    {
                        new Section(){Id = 4, Name = "sec name"},
                        new Section(){Id = 5, Name = "sec name"},
                        new Section(){Id = 6, Name = "sec name"},
                    }
                }
            };
            employees.Add(employee);
        }

        return employees;
    }

    [Benchmark]
    public List<Employee> Test_100_AutoFixture()
    {
        var fixture = new Fixture();
        var employees = fixture.CreateMany<Employee>(100);
        
        
        return employees.ToList();
    }
    

}