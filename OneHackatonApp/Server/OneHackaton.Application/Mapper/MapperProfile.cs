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
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, CreateNewUserCommand>().ReverseMap();
        }
    }
}
