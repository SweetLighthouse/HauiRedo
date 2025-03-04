using HauiRedo.Infrastructure.Repositories.Interfaces;

namespace HauiRedo.Infrastructure.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository Accounts { get; }
    IComputerRepository Computers { get; }
    Task<int> SaveChangeAsync();
}
