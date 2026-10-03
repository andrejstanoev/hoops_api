using HoopsAPI.Domain.Common;
using HoopsAPI.Domain.Enums;

namespace HoopsAPI.Domain.Models;


public class Match : BaseEntity
{
    public DateTime MatchDateTime { get; set; }
    public MatchStatus Status { get; set; } = MatchStatus.Scheduled;
    public string? Stage { get; set; }             
    public int? Attendance { get; set; }
    public int NumberOfOvertimes { get; set; } = 0;
    
    public Guid SeasonId { get; set; }
    public virtual Season Season { get; set; } = null!;
    
    public Guid ArenaId { get; set; }
    public virtual Arena Arena { get; set; } = null!;
    
    public virtual ICollection<MatchTeam> MatchTeams { get; set; } = new List<MatchTeam>();
    public virtual ICollection<MatchReferee> MatchReferees { get; set; } = new List<MatchReferee>();
    public virtual ICollection<PlayerMatchStats> PlayerStats { get; set; } = new List<PlayerMatchStats>();
}