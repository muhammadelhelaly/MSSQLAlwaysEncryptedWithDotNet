using System.ComponentModel.DataAnnotations;

namespace AlwaysEncrypted.Models;

public class Employee
{
    public int Id { get; set; }

    [MaxLength(11)]
    public string SSN { get; set; } = string.Empty;

    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;

    public double Salary { get; set; }
}