using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class MatchService : IMatchService
{
    private readonly IRepository<Match> _repository;

    public MatchService(IRepository<Match> repository)
    {
        _repository = repository;
    }

    public Task<Match> InsertAsync(MatchDto matchDto)
    {
        throw new NotImplementedException();
    }

    public Task<Match> UpdateAsync(MatchDto matchDto)
    {
        throw new NotImplementedException();
    }

    public Task<Match> DeleteAsync(MatchDto matchDto)
    {
        throw new NotImplementedException();
    }

    public Task<Match> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Match>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}