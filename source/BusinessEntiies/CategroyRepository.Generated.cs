// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategroyRepository.cs" company="Megadotnet">
// Copyright (c) 2010-2013 Peter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   The Categroy repository.
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
	public partial class CategroyRepository
	{
		private IRepository<Categroy> _repository {get;set;}
		public IRepository<Categroy> Repository
		{
			get { return _repository; }
			set { _repository = value; }
		}
		
		public CategroyRepository(IRepository<Categroy> repository)
    	{
    		Repository = repository;
    	}
		
		/// <summary>
        /// Alls enties 
        /// </summary>
        /// <returns>Alls enties</returns>
		public IEnumerable<Categroy> All()
		{
			return Repository.All();
		}

		 /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public void Add(Categroy entity)
		{
			Repository.Add(entity);
		}
		
		 /// <summary>
        /// Attaches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public void Attach(Categroy entity)
		{
		    Repository.Attach(entity);
		}
		
		/// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
		public void Delete(Categroy entity)
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