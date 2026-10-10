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

    public async Task<Match> DeleteAsync(Guid id)
    {
        var match = await GetByIdNotNullAsync(id);
        return await _repository.DeleteAsync(match);
    }

    public async Task<Match?> GetByIdAsync(Guid id)
    {
        return await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );
    }

    public async Task<Match> GetByIdNotNullAsync(Guid id)
    {
        var match = await GetByIdAsync(id);

        if (match == null)
            throw new InvalidOperationException($"Match with id {id} not found");
        
        return match;
    }

    public async Task<List<Match>> GetAllAsync()
    {
        var matches = await _repository.GetAllAsync(
            selector: x => x
        );

        return matches.ToList();
    }
}