using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using SuperShop105.Data.Entities;

namespace SuperShop105.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
