using AutoMapper;
using SignalR.DtoLayer.MenuTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class MenuTableMapping:Profile
    {
        public MenuTableMapping()
        {
            CreateMap<MenuTable, ResultMenuTableDto>();
            CreateMap<MenuTable, CreateMenuTableDto>();
            CreateMap<MenuTable, UpdateMenuDto>();
            CreateMap<MenuTable, GetMenuTableDto>();

        }
    }
}
