using Core.Concretes.DTOs;

namespace Core.Abstracts.IServices
{
    public interface IMenuService
    {
        Task<IEnumerable<MenuListItemDto>> GetAsync(string ownerId);

        Task CreateAsync(NewMenuDto newMenu);
    }
}
