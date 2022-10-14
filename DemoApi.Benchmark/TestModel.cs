namespace DemoApi.Benchmark;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public DateTime Birthday { get; set; }
    public List<Address> Addresses { get; set; }
    public Gender Gender { get; set; }
    public Department Department { get; set; }
}

public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Section> Sections { get; set; }
}

public class Section
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public enum Gender
{
    Female,
    Male,
    Other
}

public class Address
{
    public Guid Id { get; set; }
    public string Street { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public AddressType AddressType { get; set; }
}

public enum AddressType
{
    Home,
    Work
}