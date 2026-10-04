using HoopsAPI.Domain.Dto;
using HoopsAPI.Domain.Models;

namespace HoopsAPI.Service.Interface;

public interface IMatchService
{
    public Task<Match> InsertAsync(MatchDto matchDto);
    public Task<Match> UpdateAsync(MatchDto matchDto);
    public Task<Match> DeleteAsync(MatchDto matchDto);
    public Task<Match> GetByIdAsync(Guid id);
    public Task<List<Match>> GetAllAsync();
}