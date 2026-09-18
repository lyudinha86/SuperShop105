using SuperShop105.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop105.Data
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrderAsync(string userName);

    }
}
