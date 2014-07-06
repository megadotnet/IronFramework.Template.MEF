// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductRepository.cs" company="Megadotnet">
// Copyright (c) 2010-2013 Peter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   The Product repository.
//   This file is auto generated and will be overwritten as soon as the template is executed
//   Do not modify this file...
// </summary>
// --------------------------------------------------------------------------------------------------------------------	
namespace DataAccessObject
{  
    using System;
    using System.ComponentModel.Composition;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Collections.Generic;
    using BusinessEntiies;

    [Export]
	public partial class ProductRepository
	{
		private IRepository<Product> _repository {get;set;}
		public IRepository<Product> Repository
		{
			get { return _repository; }
			set { _repository = value; }
		}
		
		public ProductRepository(IRepository<Product> repository)
    	{
    		Repository = repository;
    	}
		
		/// <summary>
        /// Alls enties 
        /// </summary>
        /// <returns>Alls enties</returns>
		public IEnumerable<Product> All()
		{
			return Repository.All();
		}

		 /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public void Add(Product entity)
		{
			Repository.Add(entity);
		}
		
		 /// <summary>
        /// Attaches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public void Attach(Product entity)
		{
		    Repository.Attach(entity);
		}
		
		/// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public void Delete(Product entity)
		{
			Repository.Delete(entity);
		}

		/// <summary>
        /// Saves this instance.
        /// </summary>
		public void Save()
		{
			Repository.Save();
		}
	}
}