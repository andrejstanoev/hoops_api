using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Service.Interface;

public interface ICoachService
{
    public Task<Coach> InsertAsync(CoachDto coachDto);
    public Task<Coach> UpdateAsync(CoachDto coachDto);
    public Task<Coach> DeleteAsync(Guid id);
    public Task<Coach?> GetByIdAsync(Guid id);
    public Task<List<Coach>> GetAllAsync();
}