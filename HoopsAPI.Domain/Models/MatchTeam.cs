using HoopsAPI.Domain.Enums;

namespace HoopsAPI.Domain.Models;


public class MatchTeam
{
    public Guid MatchId { get; set; }
    public virtual Match Match { get; set; } = null!;

    public Guid TeamId { get; set; }
    public virtual Team Team { get; set; } = null!;

    public bool IsHome { get; set; }
    public int? FinalScore { get; set; }
    public MatchResult? Result { get; set; }

    public int? Q1Points { get; set; }
    public int? Q2Points { get; set; }
    public int? Q3Points { get; set; }
    public int? Q4Points { get; set; }
    public int? OtPoints { get; set; }
    
    public int? TeamRebounds { get; set; }
    public int? TeamTurnovers { get; set; }
    public int? PointsInPaint { get; set; }
    public int? FastBreakPoints { get; set; }
    public int? SecondChancePoints { get; set; }
    public int? PointsOffTurnovers { get; set; }
    
    public virtual ICollection<PlayerMatchStats> PlayerStats { get; set; } = new List<PlayerMatchStats>();
}