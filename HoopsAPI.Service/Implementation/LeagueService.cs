using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class LeagueService : ILeagueService
{
    private readonly IRepository<League> _repository;

    public LeagueService(IRepository<League> repository)
    {
        _repository = repository;
    }

    public Task<League> InsertAsync(LeagueDto leagueDto)
    {
        throw new NotImplementedException();
    }

    public Task<League> UpdateAsync(LeagueDto leagueDto)
    {
        throw new NotImplementedException();
    }

    public async Task<League> DeleteAsync(Guid id)
    {
        var league = await GetByIdNotNullAsync(id);
        return await _repository.DeleteAsync(league);
    }

    public async Task<League?> GetByIdAsync(Guid id)
    {
        var league = await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );

        return league;
    }

    public async Task<League> GetByIdNotNullAsync(Guid id)
    {
        var league = await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );

        if (league == null)
        {
            throw new InvalidOperationException($"League with id {id} not found");
        }

        return league;
    }

    public async Task<List<League>> GetAllAsync()
    {
        var leagues = await _repository.GetAllAsync(
            selector: x => x
        );
        
        return leagues.ToList();
    }
}