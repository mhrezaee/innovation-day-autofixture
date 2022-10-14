using AutoFixture;
using BenchmarkDotNet.Attributes;

namespace DemoApi.Benchmark;


[MemoryDiagnoser]
public class BenchmarkTests
{
    [Benchmark]
    public void UnitTest_With_Manual_Object()
    {
        var employee = new Employee()
        {
            Id = 2,
            Birthday = DateTime.Now,
            Gender = Gender.Female,
            Name = "some name",
            Lastname = "some last name",
            
        };
    }

    [Benchmark]
    public void UnitTest_With_AutoFixture()
    {
        var fixture = new Fixture();
        var employee = fixture.Create<Employee>();
    }
    
}