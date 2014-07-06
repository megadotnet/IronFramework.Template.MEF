// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryHelper.cs" company="Megadotnet">
//   Copyright (c) 2010-2013 Peter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   The repository helper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessObject
{
	public static class RepositoryHelper
	{
		public static IRepository<T> GetRepository<T>()
		{
			return ObjectFactory.GetInstance<IRepository<T>>();
		}

        public static IUnitOfWork GetUnitOfWork()
        {
            return ObjectFactory.GetInstance<IUnitOfWork>();
        }
		
	    public static IObjectContext GetDbContext()
		{
			return ObjectFactory.GetInstance<IObjectContext>();
		}	
		
		
		public static CategroyRepository GetCategroyRepository()
		{
			return ObjectFactory.GetInstance<CategroyRepository>();
		}


		public static ProductRepository GetProductRepository()
		{
			return ObjectFactory.GetInstance<ProductRepository>();
		}

    }
}
