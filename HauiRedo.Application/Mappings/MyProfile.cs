using HauiRedo.Application.Dtos.ComputerDto;
using HauiRedo.Domain.Entities;

namespace HauiRedo.Application.Mappings;

public class MyProfile : AutoMapper.Profile
{
    public MyProfile()
    {
        this.CreateMap<Computer, ComputerDto>().ReverseMap();
    }
}
