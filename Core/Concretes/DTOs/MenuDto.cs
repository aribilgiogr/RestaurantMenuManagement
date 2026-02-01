using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concretes.DTOs
{
    public record MenuListItemDto(int Id, bool Active, bool Deleted, string Title, string QRCodeImageUrl, int ItemCount = 0);

    public record NewMenuDto(string OwnerId, string Title, string? Description);
}
