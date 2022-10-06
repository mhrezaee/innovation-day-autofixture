using System.ComponentModel.DataAnnotations;

namespace DemoApi.Models;

public class Address
{
    public Guid Id { get; set; }
    [Required]
    [StringLength(2)]
    public string? CountryCode { get; set; }
    public string? City { get; set; }
    [StringLength(4)]
    public string? PostalCode { get; set; }
    public string? Street { get; set; }

}