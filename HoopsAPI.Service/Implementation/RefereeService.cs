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

    public Task<Referee> UpdateAsync(RefereeDto refereeDto)
    {
        throw new NotImplementedException();
    }

    public Task<Referee> DeleteAsync(RefereeDto refereeDto)
    {
        throw new NotImplementedException();
    }

    public Task<Referee> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Referee>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}