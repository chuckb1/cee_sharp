#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace crudelicious.Models;
public class Dish
{
    //establish an ID
    // Make sure this is the name of your model with "Id" added
    [Key]
    public int DishId {get; set;}
    [Required]
    [MinLength(2)]

    public string DishName {get; set;}
    [Required]
    [MinLength(2)]
    public string ChefsName {get; set;}
    [Required]
    [MinLength(10)]
    public string Description {get; set;}
    [Required]
    [Range(1, 10000000)]
    public int Calories {get; set;}
    [Required]
    [Range(1, 5)]
    public int Tastiness {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;


}