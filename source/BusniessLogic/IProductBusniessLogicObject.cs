using BusinessEntiies;
// ***********************************************************************
// Assembly         : IronFramework.MEF
// Author           : PeterLiu
// Created          : 07-04-2013
//
// Last Modified By : PeterLiu
// Last Modified On : 07-04-2013
// ***********************************************************************
// <copyright file="IProductBusniessLogicObject.cs" company="Megadotnet">
//     Copyright (c) Megadotnet. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
namespace IronFramework.MEF
{
    /// <summary>
    /// Interface IProductBusniessLogicObject
    /// </summary>
    /// <remarks>http://wintersun.cnblogs.com/</remarks>
    interface IProductBusniessLogicObject
    {
        /// <summary>
        /// Creates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        bool CreateProduct(Product product);
        /// <summary>
        /// Dels the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        bool DelProduct(Product product);
        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="pid">The pid.</param>
        /// <returns>Product.</returns>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        Product GetProduct(int pid);
        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        /// <remarks>http://wintersun.cnblogs.com/</remarks>
        bool UpdateProduct(Product product);
    }
}
