using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Maps
{
    public class MenuMapProfiles : Profile
    {
        public MenuMapProfiles()
        {
            CreateMap<Menu, MenuListItemDto>()
                .ForMember(dest => dest.ItemCount, src => src.MapFrom(x => x.MenuItems.Count));

            CreateMap<NewMenuDto, Menu>();
        }
    }
}
