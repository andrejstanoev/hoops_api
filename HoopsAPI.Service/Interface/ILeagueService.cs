using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Service.Interface;

public interface ILeagueService
{
    public Task<League> InsertAsync(LeagueDto leagueDto);
    public Task<League> UpdateAsync(LeagueDto leagueDto);
    public Task<League> DeleteAsync(Guid id);
    public Task<League?> GetByIdAsync(Guid id);
    public Task<List<League>> GetAllAsync();
}