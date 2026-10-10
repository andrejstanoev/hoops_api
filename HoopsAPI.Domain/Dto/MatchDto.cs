using HoopsAPI.Domain.Enums;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Domain.Dto;

public class MatchDto
{
    public Guid? Id { get; set; }
    public DateTime MatchDateTime { get; set; }
    public MatchStatus Status { get; set; }
    public string? Stage { get; set; }             
    public int? Attendance { get; set; }
    public int NumberOfOvertimes { get; set; }
    public Guid SeasonId { get; set; }
    public Guid ArenaId { get; set; }

}