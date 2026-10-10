namespace HoopsAPI.Domain.Dto;

public class RefereeDto
{
    public Guid? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Nationality { get; set; }
    public string? LicenseLevel { get; set; }
}