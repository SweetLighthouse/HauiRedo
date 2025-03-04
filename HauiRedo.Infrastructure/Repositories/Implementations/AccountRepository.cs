using HauiRedo.Domain.Context;
using HauiRedo.Domain.Entities;
using HauiRedo.Infrastructure.Repositories.Interfaces;

namespace HauiRedo.Infrastructure.Repositories.Implementations;

public class AccountRepository : GenericRepository<Account>, IAccountRepository
{
    public AccountRepository(MainDbContext context) : base(context)
    {
    }
}
