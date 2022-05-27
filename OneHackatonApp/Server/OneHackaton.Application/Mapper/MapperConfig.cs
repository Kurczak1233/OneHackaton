using AutoMapper;
using OneHackaton.Domain.Entities;
using OneHackaton.Infrastructure.Middlewares.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, CreateNewUserCommand>().ReverseMap();
        }
    }
}
