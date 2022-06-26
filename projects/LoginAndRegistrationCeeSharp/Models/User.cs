#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginAndRegistrationCeeSharp.Models;

public class User
{
    [Key]
    [Required]
    public int UserId {get; set;}
    [Required]
    public string UserName {get; set;}
    [EmailAddress]
    [Required]    
    public string Email {get; set;}
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8)]
    public string Password {get; set;}
    [DataType(DataType.Password)]
    [NotMapped]
    [Compare("Password")]
    public string PassConfirm {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;

}