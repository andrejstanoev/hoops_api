using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class ArenaService : IArenaService
{
    private readonly IRepository<Arena> _repository;

    public ArenaService(IRepository<Arena> repository)
    {
        _repository = repository;
    }

    public async Task<Arena> InsertAsync(ArenaDto arenaDto)
    {
        throw new NotImplementedException();
    }

    public async Task<Arena> UpdateAsync(ArenaDto arenaDto)
    {
        throw new NotImplementedException();
    }

    public async Task<Arena> DeleteAsync(Guid id)
    {
        var arena = await GetByIdNotNullAsync(id);
        var deleted = await _repository.DeleteAsync(arena);
        
        return deleted;
    }


    public async Task<Arena?> GetByIdAsync(Guid id)
    {
        var arena = await _repository.Get(
            selector: a => a,
            predicate: a => a.Id == id
        );

        return arena;
    }

    public async Task<Arena> GetByIdNotNullAsync(Guid id)
    {
        var arena = await _repository.Get(
            selector: a => a,
            predicate: a => a.Id == id
        );

        if (arena == null)
        {
            throw new InvalidOperationException($"Arena with id {id} not found");
        }

        return arena;
    }

    public async Task<List<Arena>> GetAllAsync()
    {
        var arenas = await _repository.GetAllAsync(
            selector: x => x
        );

        return arenas.ToList();
    }
}