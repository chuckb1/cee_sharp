#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace ChefsAndDishesCeeSharp.Models;

public class MyContext : DbContext 
{ 
    public MyContext(DbContextOptions options) : base(options) { }
    // the "Monsters" table name will come from the DbSet property name
    public DbSet<Chef> Chefs { get; set; }

    public DbSet<Dish> Dishes {get; set;}


}