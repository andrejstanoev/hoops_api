using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class LeagueService : ILeagueService
{
    private readonly IRepository<Coach> _repository;

    public LeagueService(IRepository<Coach> repository)
    {
        _repository = repository;
    }

    public Task<League> InsertAsync(LeagueDto leagueDto)
    {
        throw new NotImplementedException();
    }

    public Task<League> UpdateAsync(CoachDto leagueDto)
    {
        throw new NotImplementedException();
    }

    public Task<League> DeleteAsync(CoachDto leagueDto)
    {
        throw new NotImplementedException();
    }

    public Task<League> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<League>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}