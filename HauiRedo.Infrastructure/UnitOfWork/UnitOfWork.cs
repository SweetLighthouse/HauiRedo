using HauiRedo.Domain.Context;
using HauiRedo.Infrastructure.Repositories.Implementations;
using HauiRedo.Infrastructure.Repositories.Interfaces;

namespace HauiRedo.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MainDbContext _context;
    public IAccountRepository Accounts { get; }
    public IComputerRepository Computers { get; }

    public UnitOfWork(MainDbContext context)
    {
        _context = context;
        Accounts = new AccountRepository(_context);
        Computers = new ComputerRepository(_context);
    }

    public async Task<int> SaveChangeAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
