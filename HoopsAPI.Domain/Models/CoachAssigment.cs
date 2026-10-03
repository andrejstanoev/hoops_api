using HoopsAPI.Domain.Enums;

namespace HoopsAPI.Domain.Models;


public class CoachAssignment
{
    public Guid CoachId { get; set; }
    public virtual Coach Coach { get; set; } = null!;

    public Guid TeamId { get; set; }
    public virtual Team Team { get; set; } = null!;

    public Guid SeasonId { get; set; }
    public virtual Season Season { get; set; } = null!;
    
    public virtual SeasonTeam SeasonTeam { get; set; } = null!;

    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public CoachRole Role { get; set; } = CoachRole.Head;
}