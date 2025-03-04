using HauiRedo.Application.Services.Interfaces;
using HauiRedo.Domain.Entities;
using HauiRedo.Infrastructure.UnitOfWork;
using System.Linq.Expressions;

namespace HauiRedo.Application.Services.Implementations;

public class ComputerService : IComputerService
{
    private readonly IUnitOfWork _unitOfWork;

    public ComputerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Computer>> GetAllComputersAsync()
    {
        return await _unitOfWork.Computers.GetAsync();
    }

    public async Task<IEnumerable<Computer>> FindComputerAsync(Expression<Func<Computer, bool>> predicate)
    {
        return await _unitOfWork.Computers.GetAsync(predicate);
    }

    public async Task<Computer?> GetComputerByIdAsync(Guid id)
    {
        return await _unitOfWork.Computers.GetByIdAsync(id);
    }

    public async Task AddComputerAsync(Computer computer)
    {
        await _unitOfWork.Computers.AddAsync(computer);
        await _unitOfWork.SaveChangeAsync();
    }

    public async Task UpdateComputerAsync(Computer computer)
    {
        await _unitOfWork.Computers.UpdateAsync(computer);
        await _unitOfWork.SaveChangeAsync();
    }

    public async Task DeleteComputerAsync(Guid id)
    {
        var computer = await _unitOfWork.Computers.GetByIdAsync(id);
        if(computer != null)
        {
            await _unitOfWork.Computers.RemoveAsync(computer);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}