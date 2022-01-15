using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mateut_Andreea_Lab122.Models;

namespace Mateut_Andreea_Lab122.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
