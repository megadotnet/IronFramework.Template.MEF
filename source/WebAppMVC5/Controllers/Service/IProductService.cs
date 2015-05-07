using System;
namespace WebAppMVC5.Controllers
{
    public interface IProductService
    {
        void Create(WebAppMVC5.Models.ProductViewModel product);
        void Destroy(WebAppMVC5.Models.ProductViewModel product);
        System.Collections.Generic.IEnumerable<WebAppMVC5.Models.ProductViewModel> Read();
        void Update(WebAppMVC5.Models.ProductViewModel product);
    }
}
