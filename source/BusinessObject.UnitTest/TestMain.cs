// ***********************************************************************
// Assembly         : BusinessObject.UnitTest
// Author           : PeterLiu
// Created          : 07-05-2014
//
// Last Modified By : PeterLiu
// Last Modified On : 05-16-2014
// ***********************************************************************
// <copyright file="TestMain.cs" company="Megadotnet">
//     Copyright (c) Megadotnet. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BusinessEntiies;
using DataAccessObject;
using DataAccessObject.Repositories;
using IronFramework.MEF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BusinessObject.UnitTest
{
    /// <summary>
    /// Class TestMain
    /// </summary>
    /// <remarks>http://wintersun.cnblogs.com/</remarks>
   [TestClass]
    public class TestMain
    {

        /// <summary>
        /// Shoulds the get export one catelog.
        /// </summary>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        [TestMethod]
        public void ShouldGetExportOneCatelog()
        {
            var picker = new RegistrationBuilder();
            picker.ForType<DbContext>().Export<OkUStockingEntities>();
            picker.ForType<EFUnitOfWork>().Export<IUnitOfWork>();
            picker.ForType<ObjectContextAdapter>().Export<IObjectContext>();
            picker.ForType<IStoredProcedureFunctionsDAO>().Export<StoredProcedureFunctionsDAO>();
            picker.ForType<DbContext>().Export<OkUStockingEntities>();
            picker.ForType<IRepository<Product>>().Export<EFRepository<Product>>();
            picker.ForType<IRepository<Categroy>>().Export<EFRepository<Categroy>>();
            picker.ForType<ProductRepository>().Export<IRepository<Product>>();
            picker.ForType<CategroyRepository>().Export<IRepository<CategroyRepository>>();


           var catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory,"*.dll",picker); 
           var container = new CompositionContainer(catalog);

            var dd = container.GetExportedValue<IRepository<Product>>();
            var cc = container.GetExportedValue<IRepository<Categroy>>();
            var pr = container.GetExportedValue<ProductRepository>();
            var pc = container.GetExportedValue<CategroyRepository>();

            Assert.IsNotNull(dd);
            Assert.IsNotNull(cc);
            Assert.IsNotNull(pr);

            var product = pr.Repository.Find(p => p.Id == 1);
            Assert.IsNotNull(product);
            Assert.IsNotNull(product.FirstOrDefault().ProductName);

        }

        /// <summary>
        /// Shoulds the get export with different catelog.
        /// </summary>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        [TestMethod]
        public void ShouldGetExportWithDifferentCatelog()
        {
            var picker = new RegistrationBuilder();
            picker.ForType<EFUnitOfWork>().Export<IUnitOfWork>();
            picker.ForType<ObjectContextAdapter>().Export<IObjectContext>();
            picker.ForType<IStoredProcedureFunctionsDAO>().Export<StoredProcedureFunctionsDAO>();

            picker.ForType<IRepository<Product>>().Export<EFRepository<Product>>();
            picker.ForType<IRepository<Categroy>>().Export<EFRepository<Categroy>>();
            picker.ForType<ProductRepository>().Export<IRepository<Product>>();
            picker.ForType<CategroyRepository>().Export<IRepository<CategroyRepository>>();

            //Tips:should pay attention to specfic DbContext in another assembly
            var businessEntitiesPicker = new RegistrationBuilder();
            businessEntitiesPicker.ForType<DbContext>().Export<OkUStockingEntities>();

            var catalog = new AssemblyCatalog(typeof(ObjectFactory).Assembly, picker);
            var catalog1 = new AssemblyCatalog(typeof(OkUStockingEntities).Assembly, businessEntitiesPicker);
            var arggcatelog = new AggregateCatalog(new[] { catalog, catalog1 });
            var container = new CompositionContainer(arggcatelog);
            var dd = container.GetExportedValue<IRepository<Product>>();
            var cc = container.GetExportedValue<IRepository<Categroy>>();
            var pr = container.GetExportedValue<ProductRepository>();
            var pc = container.GetExportedValue<CategroyRepository>();

            Assert.IsNotNull(dd);
            Assert.IsNotNull(cc);
            Assert.IsNotNull(pr);

            var product = pr.Repository.Find(p => p.Id == 1);
            Assert.IsNotNull(product);
            Assert.IsNotNull(product.FirstOrDefault().ProductName);

        }

        /// <summary>
        /// Tests the add.
        /// </summary>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        [TestMethod]
        public void TestAdd()
        {
            var bo = new ProductBusniessLogicObject();
            var p = bo.GetProduct(1);
            Assert.IsNotNull(p);

            Assert.AreEqual(1, p.Id);
        }

    }
}
