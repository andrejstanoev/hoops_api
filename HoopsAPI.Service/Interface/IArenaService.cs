using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Service.Interface;

public interface IArenaService
{
    public Task<Arena> InsertAsync(ArenaDto arenaDto);
    public Task<Arena> UpdateAsync(ArenaDto arenaDto);
    public Task<Arena> DeleteAsync(ArenaDto arenaDto);
    public Task<Arena> GetByIdAsync(Guid id);
    public Task<List<Arena>> GetAllAsync();
}