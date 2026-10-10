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

    public async Task<Player> DeleteAsync(Guid id)
    {
        var player = await GetByIdNotNullAsync(id);
        return await _repository.DeleteAsync(player);
    }

    public async Task<Player?> GetByIdAsync(Guid id)
    {
        return await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );
    }

    public async Task<Player> GetByIdNotNullAsync(Guid id)
    {
        var player = await GetByIdAsync(id);
        
        if (player == null)
            throw new InvalidOperationException($"Player with id {id} not found");
        
        return player;
    }

    public async Task<List<Player>> GetAllAsync()
    {
        var players = await _repository.GetAllAsync(
            selector: x => x
        );

        return players.ToList();
    }
}