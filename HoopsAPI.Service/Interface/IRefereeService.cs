using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Service.Interface;

public interface IRefereeService
{
    public Task<Referee> InsertAsync(RefereeDto refereeDto);
    public Task<Referee> UpdateAsync(RefereeDto refereeDto);
    public Task<Referee> DeleteAsync(Guid id);
    public Task<Referee?> GetByIdAsync(Guid id);
    public Task<List<Referee>> GetAllAsync();
}