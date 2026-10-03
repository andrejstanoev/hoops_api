using HoopsAPI.Domain.Enums;

namespace HoopsAPI.Domain.Models;

public class Roster
{
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; set; } = null!;

    public Guid TeamId { get; set; }
    public virtual Team Team { get; set; } = null!;

    public Guid SeasonId { get; set; }
    public virtual Season Season { get; set; } = null!;
    
    public virtual SeasonTeam SeasonTeam { get; set; } = null!;

    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }        
    public int JerseyNumber { get; set; }
    public decimal? Salary { get; set; }
    public ContractType ContractType { get; set; } = ContractType.Full;
    public RosterRole RosterRole { get; set; } = RosterRole.Bench;
}