namespace HoopsAPI.Domain.Dto;

public class PlayerDto
{
    public Guid? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public decimal? Height { get; set; }
    public decimal? Weight { get; set; }
    public string? Nationality { get; set; }
    public bool IsActive { get; set; }
    public int SeasonExperience { get; set; }
    public string? PrimaryPosition { get; set; } 
}