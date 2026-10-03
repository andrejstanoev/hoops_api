using HoopsAPI.Domain.Common;

namespace HoopsAPI.Domain.Models;



public class Player : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateOnly BirthDate { get; set; }
    public decimal? Height { get; set; }
    public decimal? Weight { get; set; }
    public string? Nationality { get; set; }
    public bool IsActive { get; set; } = false;
    public int SeasonExperience { get; set; }
    public string? PrimaryPosition { get; set; } 
    

    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();
    public virtual ICollection<PlayerMatchStats> MatchStats { get; set; } = new List<PlayerMatchStats>();
}