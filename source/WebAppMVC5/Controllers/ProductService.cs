using BusinessEntiies;
using DataAccessObject;
using DataAccessObject.Repositories;
using IronFramework.Utility.EntityFramewrok;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using WebAppMVC5.Models;

namespace WebAppMVC5.Controllers
{
    public class ProductService : IDisposable, IProductService
    {
        private OkUStockingEntities entities;

        public ProductService(OkUStockingEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<ProductViewModel> Read()
        {
            return entities.Product.Select(product => new ProductViewModel
            {
                ProductID = product.Id,
                ProductName = product.ProductName,
                CategoryID = product.CategoryId,
                Category = new CategoryViewModel()
                {
                    CategoryID = product.Categroy.Id,
                    CategoryName = product.Categroy.Name
                },
                LastSupply = DateTime.Today
            });
        }

        public void Create(ProductViewModel product)
        {
            var entity = new Product();

            entity.ProductName = product.ProductName;
            entity.CategoryId = product.CategoryID.Value;

            if (entity.Id == null)
            {
                entity.CategoryId = 1;
            }

            if (product.Category != null)
            {
                entity.CategoryId = product.Category.CategoryID;
            }

            entities.Product.Add(entity);
            entities.SaveChanges();

            product.ProductID = entity.Id;
        }

        public void Update(ProductViewModel product)
        {
            var entity = new Product();

            entity.Id = product.ProductID;
            entity.ProductName = product.ProductName;

            entity.CategoryId = product.CategoryID.Value;

            if (product.Category != null)
            {
                entity.CategoryId = product.Category.CategoryID;
            }

            entities.Product.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(ProductViewModel product)
        {
            var entity = new Product();

            entity.Id = product.ProductID;

            entities.Product.Attach(entity);

            entities.Product.Remove(entity);

            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }

    /// <summary>
    /// sss
    /// </summary>
    /// <remarks>
    /// <![CDATA[
    /// No export was found for the contract 'IRepository<Product>'
///-> required by import 'repository' of part 'ProductRepository'
///-> required by import '_productRepository' of part 'ProductService'
///-> required by import '_productService' of part 'GridController'
///-> required by initial request for contract 'GridController'
///说明: 执行当前 Web 请求期间，出现未经处理的异常。请检查堆栈跟踪信息，以了解有关该错误以及代码中导致错误的出处的详细信息。 
///异常详细信息: System.Composition.Hosting.CompositionFailedException: No export was found for the contract 'IRepository<Product>'
///-> required by import 'repository' of part 'ProductRepository'
///-> required by import '_productRepository' of part 'ProductService'
///-> required by import '_productService' of part 'GridController'
///-> required by initial request for contract 'GridController'
    ///]]>
    /// </remarks>

    //[Export(typeof(IProductService))]
    //public class ProductService : IProductService
    //{
    //    private readonly ProductRepository productRepository;
    //    private readonly CategroyRepository categroyRepository;

    //    public ProductService(ProductRepository _productRepository, CategroyRepository _categroyRepository)
    //    {
    //        productRepository = _productRepository;
    //        categroyRepository = _categroyRepository;

    //    }

    //    public IEnumerable<ProductViewModel> Read()
    //    {
    //        return productRepository.All().Select(product => new ProductViewModel
    //        {
    //            ProductID = product.Id,
    //            ProductName = product.ProductName,
    //            CategoryID = product.CategoryId,
    //            Category = new CategoryViewModel()
    //            {
    //                CategoryID = product.Categroy.Id,
    //                CategoryName = product.Categroy.Name
    //            },
    //            LastSupply = DateTime.Today
    //        });
    //    }

    //    public void Create(ProductViewModel product)
    //    {
    //        var entity = new Product();

    //        entity.ProductName = product.ProductName;
    //        entity.CategoryId = product.CategoryID.Value;

    //        if (entity.Id == 0)
    //        {
    //            entity.CategoryId = 1;
    //        }

    //        if (product.Category != null)
    //        {
    //            entity.CategoryId = product.Category.CategoryID;
    //        }

    //        productRepository.Add(entity);
    //        productRepository.Save();

    //        product.ProductID = entity.Id;
    //    }

    //    public void Update(ProductViewModel product)
    //    {
    //        var entity = new Product();

    //        entity.Id = product.ProductID;
    //        entity.ProductName = product.ProductName;

    //        entity.CategoryId = product.CategoryID.Value;

    //        if (product.Category != null)
    //        {
    //            entity.CategoryId = product.Category.CategoryID;
    //        }

    //        if (StateHelpers.GetEquivalentEntityState(entity.State) == StateHelpers.GetEquivalentEntityState(State.Detached))
    //        {
    //            this.productRepository.Attach(entity);
    //        }

    //        entity.State = State.Modified;
    //        productRepository.Save();
    //    }

    //    public void Destroy(ProductViewModel product)
    //    {
    //        var entity = new Product();

    //        entity.Id = product.ProductID;

    //        productRepository.Delete(entity);
    //        productRepository.Save();
    //    }

    //}
}