using Microsoft.EntityFrameworkCore;
using SuperShop105.Data.Entities;

namespace SuperShop105.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


    }


}
