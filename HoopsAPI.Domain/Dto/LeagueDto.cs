using HoopsAPI.Domain.Enums;

namespace HoopsAPI.Domain.Dto;

public class LeagueDto
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public LeagueLevel Level { get; set; }
    public int? FoundedYear { get; set; }
}