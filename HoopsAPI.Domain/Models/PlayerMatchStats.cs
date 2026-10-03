namespace HoopsAPI.Domain.Models;

public class PlayerMatchStats
{
    public Guid MatchId { get; set; }
    public virtual Match Match { get; set; } = null!;

    public Guid TeamId { get; set; }
    public virtual Team Team { get; set; } = null!;

    public Guid PlayerId { get; set; }
    public virtual Player Player { get; set; } = null!;
    
    public virtual MatchTeam MatchTeam { get; set; } = null!;

    public bool IsStarter { get; set; } = false;
    public decimal? MinutesPlayed { get; set; }
    public int Points { get; set; } = 0;
    public int FgMade { get; set; } = 0;
    public int FgAttempted { get; set; } = 0;
    public int ThreeMade { get; set; } = 0;
    public int ThreeAttempted { get; set; } = 0;
    public int FtMade { get; set; } = 0;
    public int FtAttempted { get; set; } = 0;
    public int OffensiveRebounds { get; set; } = 0;
    public int DefensiveRebounds { get; set; } = 0;
    public int Assists { get; set; } = 0;
    public int Steals { get; set; } = 0;
    public int Blocks { get; set; } = 0;
    public int Turnovers { get; set; } = 0;
    public int PersonalFouls { get; set; } = 0;
    public int? PlusMinus { get; set; }
    public string? DnpReason { get; set; }
    
}