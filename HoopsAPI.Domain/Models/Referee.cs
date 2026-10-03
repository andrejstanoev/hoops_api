using HoopsAPI.Domain.Common;

namespace HoopsAPI.Domain.Models;



public class Referee : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Nationality { get; set; }
    public string? LicenseLevel { get; set; }

    public virtual ICollection<MatchReferee> MatchReferees { get; set; } = new List<MatchReferee>();
}