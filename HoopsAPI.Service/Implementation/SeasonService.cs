using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class SeasonService : ISeasonService
{
    private readonly IRepository<Season> _repository;

    public SeasonService(IRepository<Season> repository)
    {
        _repository = repository;
    }

    public Task<Season> InsertAsync(SeasonDto seasonDto)
    {
        throw new NotImplementedException();
    }

    public Task<Season> UpdateAsync(SeasonDto seasonDto)
    {
        throw new NotImplementedException();
    }

    public async Task<Season> DeleteAsync(Guid id)
    {
        var season = await GetByIdNotNullAsync(id);
        return await _repository.DeleteAsync(season);
    }

    public async Task<Season?> GetByIdAsync(Guid id)
    {
        return await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );
    }

    public async Task<Season> GetByIdNotNullAsync(Guid id)
    {
        var season = await GetByIdAsync(id);

        if (season == null)
            throw new InvalidOperationException($"Season with id {id} not found");

        return season;
    }

    public async Task<List<Season>> GetAllAsync()
    {
        var seasons = await _repository.GetAllAsync(
            selector: x => x
        );

        return seasons.ToList();
    }
}