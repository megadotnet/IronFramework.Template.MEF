// ***********************************************************************
// Assembly         : ConsoleTesting
// Author           : PeterLiu
// Created          : 07-05-2014
//
// Last Modified By : PeterLiu
// Last Modified On : 05-16-2014
// ***********************************************************************
// <copyright file="Program.cs" company="Megadotnet">
//     Copyright (c) Megadotnet. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BusinessEntiies;
using DataAccessObject;
using DataAccessObject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    /// <summary>
    /// Class Program
    /// </summary>
    /// <remarks>http://wintersun.cnblogs.com/</remarks>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        static void Main(string[] args)
        {
            var picker = new RegistrationBuilder();
            picker.ForType<DbContext>().Export<OkUStockingEntities>();
            picker.ForType<ObjectContextAdapter>().Export<IObjectContext>();
            picker.ForType<EFUnitOfWork>().Export<IUnitOfWork>();

            picker.ForType<IStoredProcedureFunctionsDAO>().Export<StoredProcedureFunctionsDAO>();
            // picker.ForType<DbContext>().Export<OkUStockingEntities>();
            picker.ForType<IRepository<Product>>().Export<EFRepository<Product>>();
            picker.ForType<IRepository<Categroy>>().Export<EFRepository<Categroy>>();
            picker.ForType<ProductRepository>().Export<IRepository<Product>>();
            picker.ForType<CategroyRepository>().Export<IRepository<CategroyRepository>>();

            string path = AppDomain.CurrentDomain.BaseDirectory;
            var catalog = new DirectoryCatalog( path,@"*.dll", picker);
            var container = new CompositionContainer(catalog);

            var pr = container.GetExportedValue<ProductRepository>();
            var pc = container.GetExportedValue<CategroyRepository>();

            var product = pr.Repository.Find(p => p.Id == 1);
            Console.Write(product.SingleOrDefault().ProductName);
        }
    }
}
