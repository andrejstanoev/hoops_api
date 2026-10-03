using HoopsAPI.Domain.Common;
using HoopsAPI.Domain.Enums;

namespace HoopsAPI.Domain.Models;



public class League : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Country { get; set; } = null!;
    public LeagueLevel Level { get; set; }
    public int? FoundedYear { get; set; }
    
    public virtual ICollection<Season> Seasons { get; set; } = new List<Season>();
}