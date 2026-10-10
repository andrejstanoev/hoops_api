namespace HoopsAPI.Domain.Dto;

public class ArenaDto
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string? Country { get; set; }
    public int? Capacity { get; set; }
}