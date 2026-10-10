using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class TeamService : ITeamService
{
    private readonly IRepository<Team> _repository;

    public TeamService(IRepository<Team> repository)
    {
        _repository = repository;
    }

    public Task<Team> InsertAsync(TeamDto teamDto)
    {
        throw new NotImplementedException();
    }

    public Task<Team> UpdateAsync(TeamDto teamDto)
    {
        throw new NotImplementedException();
    }

    public async Task<Team> DeleteAsync(Guid id)
    {
        var team = await GetByIdNotNull(id);
        return await _repository.DeleteAsync(team);
    }

    public async Task<Team?> GetByIdAsync(Guid id)
    {
        return await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );
    }

    public async Task<Team> GetByIdNotNull(Guid id)
    {
        var team = await GetByIdAsync(id);

        if (team == null)
            throw new InvalidOperationException($"Team with id {id} not found");

        return team;
    }

    public async Task<List<Team>> GetAllAsync()
    {
        var teams = await _repository.GetAllAsync(
            selector: x => x
        );

        return teams.ToList();
    }
}