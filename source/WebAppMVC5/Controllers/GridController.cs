using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using WebAppMVC5.Models;
using BusinessEntiies;

namespace WebAppMVC5.Controllers
{
    public partial class GridController : Controller
    {
        private readonly IProductService productService;

        public GridController(IProductService _productService)
        {
            productService = _productService;
        }

        public ActionResult ForeignKeyColumn()
        {
            PopulateCategories();
            return View();
        }

        public ActionResult ForeignKeyColumn_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.Read().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ForeignKeyColumn_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<ProductViewModel> products)
        {
            if (products != null && ModelState.IsValid)
            {
                foreach (var product in products)
                {
                    productService.Update(product);
                }
            }

            return Json(products.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ForeignKeyColumn_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<ProductViewModel> products)
        {
            var results = new List<ProductViewModel>();
            if (products != null && ModelState.IsValid)
            {
                foreach (var product in products)
                {
                    productService.Create(product);
                    results.Add(product);
                }
            }

            return Json(results.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ForeignKeyColumn_Destroy([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<ProductViewModel> products)
        {
            foreach (var product in products)
            {
                productService.Destroy(product);
            }

            return Json(products.ToDataSourceResult(request, ModelState));
        }

        private void PopulateCategories()
        {
            var dataContext = new OkUStockingEntities();
            var categories = dataContext.Categroy
                        .Select(c => new CategoryViewModel
                        {
                            CategoryID = c.Id,
                            CategoryName = c.Name
                        })
                        .OrderBy(e => e.CategoryName);

            ViewData["categories"] = categories;
            ViewData["defaultCategory"] = categories.First();
        }
        public ActionResult Index()
        {
            return View();
        }
    }


}