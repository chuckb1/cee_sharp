#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlannerCeeSharp.Models;

public class RSVP
{
    [Key]
    public int RSVPId {get; set;}
    public int UserId {get; set;}
    public User? UserWhoRSVPed {get; set;}
    public int WeddingId {get; set;}
    public Wedding? WeddingRSVPed {get; set;}
}