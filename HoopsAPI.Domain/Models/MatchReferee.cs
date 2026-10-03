using HoopsAPI.Domain.Enums;

namespace HoopsAPI.Domain.Models;

public class MatchReferee
{
    public Guid MatchId { get; set; }
    public virtual Match Match { get; set; } = null!;

    public Guid RefereeId { get; set; }
    public virtual Referee Referee { get; set; } = null!;

    public RefereeRole Role { get; set; } = RefereeRole.CrewChief;
}