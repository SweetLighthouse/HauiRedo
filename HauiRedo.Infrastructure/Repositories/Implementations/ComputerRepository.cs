using HauiRedo.Domain.Context;
using HauiRedo.Domain.Entities;
using HauiRedo.Infrastructure.Repositories.Interfaces;

namespace HauiRedo.Infrastructure.Repositories.Implementations;

public class ComputerRepository : GenericRepository<Computer>, IComputerRepository
{
    public ComputerRepository(MainDbContext context) : base(context)
    {
    }
}
