using Core.Abstracts;
using Core.Abstracts.IRepositories;
using Data.Contexts;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork(ApplicationContext context) : IUnitOfWork
    {
        private ICuisineRepository? cuisineRepository;
        public ICuisineRepository CuisineRepository => cuisineRepository ??= new CuisineRepository(context);

        private IMealTypeRepository? mealTypeRepository;
        public IMealTypeRepository MealTypeRepository => mealTypeRepository ??= new MealTypeRepository(context);

        private IMenuRepository? menuRepository;
        public IMenuRepository MenuRepository => menuRepository ??= new MenuRepository(context);

        private IMenuItemRepository? menuItemRepository;
        public IMenuItemRepository MenuItemRepository => menuItemRepository ??= new MenuItemRepository(context);

        private IDietRepository? dietRepository;
        public IDietRepository DietRepository => dietRepository ??= new DietRepository(context);

        public async Task CommitAsync()
        {
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await DisposeAsync();
                throw;
            }
        }

        public async ValueTask DisposeAsync()
        {
            await context.DisposeAsync();
        }
    }
}
