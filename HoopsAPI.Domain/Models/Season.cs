using HoopsAPI.Domain.Common;

namespace HoopsAPI.Domain.Models;



public class Season : BaseEntity
{
    public string Name { get; set; } = null!;        
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    
    public Guid LeagueId { get; set; }
    public virtual League League { get; set; } = null!;
    
    public virtual ICollection<Match> Matches { get; set; } = new List<Match>();
    
    public virtual ICollection<SeasonTeam> SeasonTeams { get; set; } = new List<SeasonTeam>();
    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();
    public virtual ICollection<CoachAssignment> CoachAssignments { get; set; } = new List<CoachAssignment>();
}