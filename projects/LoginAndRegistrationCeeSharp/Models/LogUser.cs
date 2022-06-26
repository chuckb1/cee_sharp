#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginAndRegistrationCeeSharp.Models;

public class LogUser
{
    [EmailAddress]
    [Required]
    public string LogEmail {get; set;}
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8)]
    public string LogPassword {get; set;}
}