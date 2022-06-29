#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlannerCeeSharp.Models;


public class User
{
    [Key]
    public int UserId {get; set;}
    [Required]
    [MinLength(2)]
    public string UserName {get; set;}
    [EmailAddress]
    [Required]    
    //Don't forget to verify that this is a unique Email!!
    public string Email {get; set;}
    [Required]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string Password {get; set;}
    [Required]
    [NotMapped]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string PassConfirm {get; set;}

    public List<Wedding> UsersWedding {get; set;} = new List<Wedding>();
    public List<RSVP> WeddingsRSVPed {get; set;} = new List<RSVP>();
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}