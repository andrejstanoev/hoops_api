using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class RefereeService : IRefereeService
{
    private readonly IRepository<Referee> _repository;

    public RefereeService(IRepository<Referee> repository)
    {
        _repository = repository;
    }

    public Task<Referee> InsertAsync(RefereeDto refereeDto)
    {
        throw new NotImplementedException();
    }

    public async Task<Referee> UpdateAsync(RefereeDto refereeDto)
    {
        throw new NotImplementedException();
    }

    public async Task<Referee> DeleteAsync(Guid id)
    {
        var referee = await GetByIdNotNullAsync(id);
        return await _repository.DeleteAsync(referee);
    }

    public async Task<Referee?> GetByIdAsync(Guid id)
    {
        return await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );
    }

    public async Task<Referee> GetByIdNotNullAsync(Guid id)
    {
        var referee = await GetByIdAsync(id);
        
        if (referee == null)
            throw new InvalidOperationException($"Referee with id {id} not found");
        
        return referee;
    }
    
    public async Task<List<Referee>> GetAllAsync()
    {
        var referees = await _repository.GetAllAsync(
            selector: x => x
        );

        return referees.ToList();
    }
}