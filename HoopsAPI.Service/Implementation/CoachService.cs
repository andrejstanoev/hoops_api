using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class CoachService : ICoachService
{
    private readonly IRepository<Coach> _repository;

    public CoachService(IRepository<Coach> repository)
    {
        _repository = repository;
    }

    public Task<Coach> InsertAsync(CoachDto coachDto)
    {
        throw new NotImplementedException();
    }

    public Task<Coach> UpdateAsync(CoachDto coachDto)
    {
        throw new NotImplementedException();
    }

    public async Task<Coach> DeleteAsync(Guid id)
    {
        var coach = await GetByIdNotNullAsync(id);
        
        return await _repository.DeleteAsync(coach);
    }

    public async Task<Coach?> GetByIdAsync(Guid id)
    {
        var coach = await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );

        return coach;
    }

    public async Task<Coach> GetByIdNotNullAsync(Guid id)
    {
        var coach = await _repository.Get(
            selector: x => x,
            predicate: x => x.Id == id
        );

        if (coach == null)
        {
            throw new InvalidOperationException($"Coach with id {id} not found");
        }

        return coach;
    }

    public async Task<List<Coach>> GetAllAsync()
    {
        var coaches = await _repository.GetAllAsync(
            selector: x => x
        );

        return coaches.ToList();
    }
}