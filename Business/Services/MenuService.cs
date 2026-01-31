using Core.Abstracts;
using Core.Abstracts.IServices;

namespace Business.Services
{
    public class MenuService(IUnitOfWork unitOfWork) : IMenuService
    {
    }
}
