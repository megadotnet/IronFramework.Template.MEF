using BusinessEntiies;
using DataAccessObject;
using DataAccessObject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Composition.Convention;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebAppMVC5.Controllers;

namespace WebAppMVC5.App_Start
{
    /// <summary>
    /// MefContainer
    /// </summary>
    public static class MefContainer
    {
        public static void ConfigureContainer()
        {
            var containerConventions = new ConventionBuilder();

            containerConventions.ForType<OkUStockingEntities>()
                .Export()
                .InstancePerHttpRequest();

            containerConventions.ForType<ObjectContextAdapter>()
                .ExportInterfaces()
                .SelectConstructorWithMostParameters()
                .InstancePerHttpRequest();

            containerConventions.ForType<EFUnitOfWork>()
                .ExportInterfaces()
                .SelectConstructorWithMostParameters()
                .InstancePerHttpRequest();

            containerConventions.ForType<StoredProcedureFunctionsDAO>()
        .ExportInterfaces()
        .SelectConstructorWithMostParameters()
        .InstancePerHttpRequest();

         #region Generic type issue with ConventionBuilder
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
            containerConventions.ForType<EFRepository<Product>>()
         .Export<IRepository<Product>>()
         .ExportInterfaces()
        .SelectConstructorWithMostParameters()
        .InstancePerHttpRequest();

            containerConventions.ForType<EFRepository<Categroy>>()
     .Export<IRepository<Categroy>>()
        .SelectConstructorWithMostParameters()
        .InstancePerHttpRequest(); 
            #endregion

            containerConventions.ForType<ProductRepository>()
         .Export()
            .SelectConstructorWithMostParameters()
        .InstancePerHttpRequest();

            containerConventions.ForType<CategroyRepository>()
    .Export()
       .SelectConstructorWithMostParameters()
  .InstancePerHttpRequest();


            containerConventions.ForType<ProductService>()
  .ExportInterfaces()
   .SelectConstructorWithMostParameters()
  .InstancePerHttpRequest();

            containerConventions.ForTypesDerivedFrom<Controller>()
                  .Export<IController>()
                  .Export()
                  .SelectConstructorWithMostParameters();



            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            var catalog = new DirectoryCatalog(path, @"*.dll");

            var containerConfig = new ContainerConfiguration();

            IEnumerable<Assembly> assemblies = new Assembly[] {
             Assembly.GetExecutingAssembly(),
             typeof(ProductRepository).GetTypeInfo().Assembly,
              typeof(OkUStockingEntities).GetTypeInfo().Assembly
            };

            containerConfig.WithAssemblies(assemblies, containerConventions);
            containerConfig.CreateContainer().UseWithMvc();


         
        }
    }
}