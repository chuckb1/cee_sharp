#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChefsAndDishesCeeSharp.Models;
public class Chef
{
    [Key]
    [Required]
    public int ChefId {get; set;}
    [Required]
    [MinLength(2)]
    public string ChefFirstName {get; set;}
    [Required]
    [MinLength(2)]
    public string ChefLastName {get; set;}
    [Required]
    [DataType(DataType.Date)]
    [PastDate]
    [Over18]
    
    public DateTime ChefDOB {get; set;}

    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;

    public List<Dish> CreatedMessages {get; set;} = new List<Dish>();

}
public class Over18Attribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime ChefDOB = (DateTime)value;
        var today = DateTime.Now;
        var age = today.Year - ChefDOB.Year;
        if (age < 18)
            return new ValidationResult("Must be over 18 to be a Chef!");
        return ValidationResult.Success;
    }
}
public class PastDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime ChefDOB = (DateTime)value;
        var today = DateTime.Now;
        var age = today.Year - ChefDOB.Year;
        if (ChefDOB > today)
            return new ValidationResult("Date of Birth must be a past date!");
        return ValidationResult.Success;
    }
}

