using Core.Abstracts.IRepositories;

namespace Core.Abstracts
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        ICuisineRepository CuisineRepository { get; }
        IMealTypeRepository MealTypeRepository { get; }
        IMenuRepository MenuRepository { get; }
        IMenuItemRepository MenuItemRepository { get; }
        IDietRepository DietRepository { get; }
        Task CommitAsync();
    }
}
