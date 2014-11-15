using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using BusinessEntiies;
using DataAccessObject;
	
namespace IronFramework.MEF
{   
   [Export]
	public class ProductBO : IProductBO
	{

        /// <summary>
        /// The Product repository
        /// </summary>
        private readonly ProductRepository entiesrepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBusniessLogicObject"/> class.
        /// </summary>
        public ProductBO()
        {
            this.entiesrepository = RepositoryHelper.GetProductRepository();
        }


        /// <summary>
        /// FindEnties
        /// </summary>
        /// <param name="pageIndex">pageIndex</param>
        /// <param name="pageSize">pageSize</param>
        /// <returns>Enties</returns>
        public Utility.UI.PagedList<Product> FindEnties(int? pageIndex, int pageSize)
        {
             return entiesrepository.Repository.Find(p => p.Id>0, p => p.Id, pageIndex, pageSize);
        }

        /// <summary>
        /// CreateEntiy
        /// </summary>
        /// <param name="product">The entity.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool CreateEntiy(Product t)
        {
            entiesrepository.Add(t);
            entiesrepository.Save();
            return true;
        }

        /// <summary>
        /// Gets the Entiy
        /// </summary>
        /// <param name="pid">The pid.</param>
        /// <returns>Entiy</returns>
        public Product GetEntiy(int _id)
        {
             return entiesrepository.Repository.Single(e => e.Id == _id);
        }

        /// <summary>
        /// Dels the Entiy.
        /// </summary>
        /// <param name="Entiy">The Entiy.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool DelEntiy(Product t)
        {
            entiesrepository.Delete(t);
            entiesrepository.Save();
            return true;
        }

         /// <summary>
        /// Updates the Entiy.
        /// </summary>
        /// <param name="Entiy">The Entiy.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</return
        public bool UpdateEntiy(Product t)
        {
            entiesrepository.Save();
            return true;
        }
	}
}