namespace HoopsAPI.Domain.Dto;

public class CoachDto
{
    public Guid? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly? BirthDate { get; set; }  
    public string? Nationality { get; set; }
}