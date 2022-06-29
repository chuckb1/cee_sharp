#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlannerCeeSharp.Models;

public class Wedding
{
    [Key]
    public int WeddingId {get; set;}
    [Required]
    [MinLength(2)]
    public string Wedder1 {get; set;}
    [Required]
    [MinLength(2)]
    public string Wedder2 {get; set;}
    [Required]
    [FutureDate]
    public DateTime WeddingDate {get; set;}
    [Required]
    public string Address {get; set;}
    public int UserId {get; set;}
    public User? BrideGroom {get; set;}
    public List<RSVP> UsersWhoRSVPed {get; set;} = new List<RSVP>();
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime WeddingDate = (DateTime)value;
        var today = DateTime.Now;
        if (WeddingDate < today)
            return new ValidationResult("Wedding date be a future date!");
        return ValidationResult.Success;
    }
}