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

    public Task<Coach> DeleteAsync(CoachDto coachDto)
    {
        throw new NotImplementedException();
    }

    public Task<Coach> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Coach>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}