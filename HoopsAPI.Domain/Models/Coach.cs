using HoopsAPI.Domain.Common;

namespace HoopsAPI.Domain.Models;


public class Coach : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateOnly? BirthDate { get; set; } = DateOnly.MinValue;     
    public string? Nationality { get; set; } = string.Empty;       
    
    public virtual ICollection<CoachAssignment> CoachAssignments { get; set; } = new List<CoachAssignment>();
}