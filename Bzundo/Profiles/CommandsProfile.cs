using AutoMapper;
using Bzundo.DTOS;
using Bzundo.Models;
using Microsoft.EntityFrameworkCore;


namespace Bzundo.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<BzundoCmd, CommandReadDto>();
            CreateMap<CommandCreateDto, BzundoCmd>();
        }
    }
}