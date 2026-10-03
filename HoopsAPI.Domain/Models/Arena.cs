
using HoopsAPI.Domain.Common;

namespace HoopsAPI.Domain.Models;



public class Arena : BaseEntity
{
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string? Country { get; set; }
    public int? Capacity { get; set; }
    
    public virtual ICollection<Match> Matches { get; set; } = new List<Match>();
}