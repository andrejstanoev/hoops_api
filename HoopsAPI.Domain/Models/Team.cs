using HoopsAPI.Domain.Common;
namespace HoopsAPI.Domain.Models;



public class Team : BaseEntity
{
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string Abbreviation { get; set; } = null!;
    public int? FoundedYear { get; set; }

    public virtual ICollection<SeasonTeam> SeasonTeams { get; set; } = new List<SeasonTeam>();
    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();
    public virtual ICollection<CoachAssignment> CoachAssignments { get; set; } = new List<CoachAssignment>();
    public virtual ICollection<MatchTeam> MatchTeams { get; set; } = new List<MatchTeam>();
    public virtual ICollection<PlayerMatchStats> PlayerMatchStats { get; set; } = new List<PlayerMatchStats>();
}