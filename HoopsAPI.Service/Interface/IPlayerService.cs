using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Service.Interface;

public interface IPlayerService
{
    public Task<Player> InsertAsync(PlayerDto playerDto);
    public Task<Player> UpdateAsync(PlayerDto playerDto);
    public Task<Player> DeleteAsync(PlayerDto playerDto);
    public Task<Player> GetByIdAsync(Guid id);
    public Task<List<Player>> GetAllAsync();
}