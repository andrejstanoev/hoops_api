namespace HoopsAPI.Domain.Models;



public class SeasonTeam
{
    public Guid SeasonId { get; set; }
    public virtual Season Season { get; set; } = null!;

    public Guid TeamId { get; set; }
    public virtual Team Team { get; set; } = null!;

    public string? SeedGroup { get; set; }
    
    public string? Division { get; set; }
    
    public string? Conference { get; set; }
    
    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();
    public virtual ICollection<CoachAssignment> CoachAssignments { get; set; } = new List<CoachAssignment>();
}