using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class PlayerService : IPlayerService
{
    private readonly IRepository<Player> _repository;

    public PlayerService(IRepository<Player> repository)
    {
        _repository = repository;
    }

    public Task<Player> InsertAsync(PlayerDto playerDto)
    {
        throw new NotImplementedException();
    }

    public Task<Player> UpdateAsync(PlayerDto playerDto)
    {
        throw new NotImplementedException();
    }

    public Task<Player> DeleteAsync(PlayerDto playerDto)
    {
        throw new NotImplementedException();
    }

    public Task<Player> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Player>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}