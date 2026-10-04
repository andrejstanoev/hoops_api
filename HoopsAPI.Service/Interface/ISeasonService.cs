using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Service.Interface;

public interface ISeasonService
{
    public Task<Season> InsertAsync(SeasonDto seasonDto);
    public Task<Season> UpdateAsync(SeasonDto seasonDto);
    public Task<Season> DeleteAsync(SeasonDto seasonDto);
    public Task<Season> GetByIdAsync(Guid id);
    public Task<List<Season>> GetAllAsync();
}