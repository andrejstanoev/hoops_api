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

    public Task<Team> DeleteAsync(TeamDto teamDto)
    {
        throw new NotImplementedException();
    }

    public Task<Team> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Team>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}