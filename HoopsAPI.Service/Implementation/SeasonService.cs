using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;
using HoopsAPI.Repository.Interface;
using HoopsAPI.Service.Interface;

namespace HoopsAPI.Service.Implementation;

public class SeasonService : ISeasonService
{
    
    private readonly IRepository<Season> _repository;

    public SeasonService(IRepository<Season> repository)
    {
        _repository = repository;
    }

    public Task<Season> InsertAsync(SeasonDto seasonDto)
    {
        throw new NotImplementedException();
    }

    public Task<Season> UpdateAsync(SeasonDto seasonDto)
    {
        throw new NotImplementedException();
    }

    public Task<Season> DeleteAsync(SeasonDto seasonDto)
    {
        throw new NotImplementedException();
    }

    public Task<Season> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Season>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}