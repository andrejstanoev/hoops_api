namespace HoopsAPI.Domain.Dto;

public class SeasonDto
{
    public Guid? Id { get; set; }
    public string Name { get; set; }     
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public Guid LeagueId { get; set; }
}