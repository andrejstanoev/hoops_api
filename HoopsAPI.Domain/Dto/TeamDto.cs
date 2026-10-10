namespace HoopsAPI.Domain.Dto;

public class TeamDto
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; } 
    public string Country { get; set; }
    public string Abbreviation { get; set; }
    public int? FoundedYear { get; set; }
}