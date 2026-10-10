using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Service.Interface;

public interface ITeamService
{
    public Task<Team> InsertAsync(TeamDto teamDto);
    public Task<Team> UpdateAsync(TeamDto teamDto);
    public Task<Team> DeleteAsync(Guid id);
    public Task<Team?> GetByIdAsync(Guid id);
    public Task<List<Team>> GetAllAsync();
}