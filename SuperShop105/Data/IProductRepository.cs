using Microsoft.EntityFrameworkCore;
using SuperShop105.Data.Entities;
using System.Linq;


namespace SuperShop105.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();
     
    }
}
