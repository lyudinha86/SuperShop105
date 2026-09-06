using SuperShop105.Data.Entities;
using SuperShop105.Models;

namespace SuperShop105.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool isNew);
        ProductViewModel ToProductViewModel(Product product);
    }
}
