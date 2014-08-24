using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using BusinessEntiies;
using DataAccessObject;
	
namespace IronFramework.MEF
{   
   [Export]
	public class CategroyBO : ICategroyBO
	{

        /// <summary>
        /// The Categroy repository
        /// </summary>
        private readonly CategroyRepository entiesrepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategroyBusniessLogicObject"/> class.
        /// </summary>
        public CategroyBO()
        {
            this.entiesrepository = RepositoryHelper.GetCategroyRepository();
        }


        /// <summary>
        /// FindEnties
        /// </summary>
        /// <param name="pageIndex">pageIndex</param>
        /// <param name="pageSize">pageSize</param>
        /// <returns>Enties</returns>
        public Utility.UI.PagedList<Categroy> FindEnties(int? pageIndex, int pageSize)
        {
             return entiesrepository.Repository.Find(p => p.Id>0, p => p.Id, pageIndex, pageSize);
        }

        /// <summary>
        /// CreateEntiy
        /// </summary>
        /// <param name="product">The entity.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool CreateEntiy(Categroy t)
        {
            entiesrepository.Repository.Add(t);
            entiesrepository.Save();
            return true;
        }

        /// <summary>
        /// Gets the Entiy
        /// </summary>
        /// <param name="pid">The pid.</param>
        /// <returns>Entiy</returns>
        public Categroy GetEntiy(int _id)
        {
             return entiesrepository.Repository.Single(e => e.Id == _id);
        }

        /// <summary>
        /// Dels the Entiy.
        /// </summary>
        /// <param name="Entiy">The Entiy.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool DelEntiy(Categroy t)
        {
            entiesrepository.Repository.Delete(t);
            entiesrepository.Save();
            return true;
        }

         /// <summary>
        /// Updates the Entiy.
        /// </summary>
        /// <param name="Entiy">The Entiy.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</return
        public bool UpdateEntiy(Categroy t)
        {
            entiesrepository.Repository.Save();
            return true;
        }
	}
}