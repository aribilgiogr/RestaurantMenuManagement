using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Business.Services
{
    public class MenuService(IUnitOfWork unitOfWork, IMapper mapper) : IMenuService
    {
        public async Task CreateAsync(NewMenuDto newMenu)
        {
            var menu = mapper.Map<Menu>(newMenu);
            await unitOfWork.MenuRepository.CreateAsync(menu);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<MenuListItemDto>> GetAsync(string ownerId)
        {
            var menus = await unitOfWork.MenuRepository.FindManyAsync(x => x.OwnerId == ownerId);
            return mapper.Map<IEnumerable<MenuListItemDto>>(menus);
        }
    }
}
