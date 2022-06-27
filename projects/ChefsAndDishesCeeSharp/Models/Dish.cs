#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChefsAndDishesCeeSharp.Models;
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
    [MinLength(10)]
    public string Description {get; set;}
    [Required]
    [Range(1, 10000000)]
    public int Calories {get; set;}
    [Required]
    [Range(1, 5)]
    public int Tastiness {get; set;}
    [Required]
    public int ChefId {get; set;}
    //Navigation property that lets us see the whole Chef
    
    public Chef? Creator {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;
}