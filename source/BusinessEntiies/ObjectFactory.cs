// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectFactory.cs" company="Megadotnet">
//   Copyright (c) 2010-2013 Peter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   ObjectFactory
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessObject
{
    using System.ComponentModel.Composition.Registration;
    using System.ComponentModel.Composition.Hosting;
    using System.Data.Entity;

    using BusinessEntiies;

    using DataAccessObject.Repositories;
    using System;
    
    /// <summary>
    /// ObjectFactory
    /// </summary>
    public class ObjectFactory
    {
       private static CompositionContainer container;

       static ObjectFactory()
       {
            var picker = new RegistrationBuilder();
           picker.ForType<EFUnitOfWork>().Export<IUnitOfWork>();
           picker.ForType<DataAccessObject.Repositories.IStoredProcedureFunctionsDAO>().Export<DataAccessObject.Repositories.StoredProcedureFunctionsDAO>();
           picker.ForType<ObjectContextAdapter>().Export<IObjectContext>();
           picker.ForType<DbContext>().Export<OkUStockingEntities>();

		            picker.ForType<IRepository<Categroy>>().Export<EFRepository<Categroy>>();	
            picker.ForType<IRepository<Product>>().Export<EFRepository<Product>>();	

		            picker.ForType<CategroyRepository>().Export<IRepository<Categroy>>();	
            picker.ForType<ProductRepository>().Export<IRepository<Product>>();	
           var catalog =  new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory,"*.dll",picker); 
            container = new CompositionContainer(catalog);
        }
         
       /// <summary>
       /// Gets the instance.
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <returns></returns>
        public static T GetInstance<T>()
        {
            return container.GetExportedValue<T>();
        }

    }
	
}