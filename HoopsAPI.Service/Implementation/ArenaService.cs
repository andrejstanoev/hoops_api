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

    public async Task<Arena> DeleteAsync(ArenaDto arenaDto)
    {
        throw new NotImplementedException();
    }

    public async Task<Arena> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Arena>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}