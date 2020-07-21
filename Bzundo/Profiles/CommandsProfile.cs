using AutoMapper;
using Bzundo.DTOS;
using Bzundo.Models;


namespace Bzundo.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<BzundoCmd, CommandReadDto>();
        }
    }
}