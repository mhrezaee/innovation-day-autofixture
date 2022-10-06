using System.ComponentModel.DataAnnotations;

namespace DemoApi.Models;

public class User
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string? Firstname { get; set; }
    [Required]
    public string? Lastname { get; set; }
    [Required]
    //[EmailAddress]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? ConfirmPassword { get; set; }

    public Guid AddressId { get; set; }
    public virtual Address Address { get; set; }
}