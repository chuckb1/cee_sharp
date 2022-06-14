using System.ComponentModel.DataAnnotations;
namespace dojoSurvey2.Models;
#pragma warning disable CS8618
public class Ninja
{
    [Required (ErrorMessage = "Name is Required!")]
    [MinLength(2)]
    public string NinjaName {get; set;}
    [Required (ErrorMessage = "Location is Required!")]
    [MinLength(2)]
    public string Location {get; set;}
    [Required(ErrorMessage = "FavLanguage is Required!")]
    [MinLength(2)]
    public string FavLanguage {get; set;}
    public string Comment {get; set;}
}