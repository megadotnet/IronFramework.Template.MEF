// ***********************************************************************
// Assembly         : IronFramework.MEF
// Author           : PeterLiu
// Created          : 05-11-2013
//
// Last Modified By : PeterLiu
// Last Modified On : 07-02-2013
// ***********************************************************************
// <copyright file="ProductBll.cs" company="Megadotnet">
//     Copyright (c) Megadotnet. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using IronFramework.MEF;
using BusinessEntiies;
using DataAccessObject;

namespace IronFramework.MEF
{
    /// <summary>
    /// Product Business Object
    /// </summary>
    /// <remarks>http://wintersun.cnblogs.com/</remarks>
    [Export]
    public partial class ProductBusniessLogicObject : IronFramework.MEF.IProductBusniessLogicObject
    {
        /// <summary>
        /// The product repository
        /// </summary>
        private readonly ProductRepository productRepository;
        //private readonly IObjectContext context;
        //private readonly IUnitOfWork uow;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBusniessLogicObject"/> class.
        /// </summary>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        public ProductBusniessLogicObject()
        {
            //this.context = RepositoryHelper.GetDbContext();
            //this.uow = RepositoryHelper.GetUnitOfWork(context);
            //this.productRepository = RepositoryHelper.GetProductRepository(context);
            this.productRepository = RepositoryHelper.GetProductRepository();
        }

        /// <summary>
        /// Creates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        public bool CreateProduct(Product product)
        {
            productRepository.Repository.Add(product);
            this.productRepository.Save();
            return true;
        }

        /// <summary>
        /// Dels the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        public bool DelProduct(Product product)
        {
            productRepository.Repository.Delete(product);
            this.productRepository.Save();
            return true;
        }

        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        public bool UpdateProduct(Product product)
        {
            productRepository.Repository.Save();
            return true;
        }

        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="pid">The pid.</param>
        /// <returns>Product.</returns>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        public Product GetProduct(int pid)
        {
            return productRepository.Repository.Single(e => e.Id == pid);
        }
    }
}