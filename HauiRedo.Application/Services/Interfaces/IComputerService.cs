using HauiRedo.Domain.Entities;
using System.Linq.Expressions;

namespace HauiRedo.Application.Services.Interfaces;

public interface IComputerService
{
    Task<IEnumerable<Computer>> GetAllComputersAsync();
    Task<IEnumerable<Computer>> FindComputerAsync(Expression<Func<Computer, bool>> predicate);
    Task<Computer?> GetComputerByIdAsync(Guid id);
    Task AddComputerAsync(Computer computer);
    Task UpdateComputerAsync(Computer computer);
    Task DeleteComputerAsync(Guid id);
}
