
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Megadonet">
//   Copyright (c) 2010-2014 Peter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   a interface of data acccess repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace IronFramework.MEF
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using IronFramework.Utility.UI;

    /// <summary>
    /// a interface of data acccess repository.
    /// </summary>
    /// <typeparam name="T">entity</typeparam>
    public interface IBusniessLogicObject<T>
    {
        #region Public Methods

        /// <summary>
        /// The find enties.
        /// </summary>
        /// <param name="pageIndex">
        /// The page index.
        /// </param>
        /// <param name="pageSize">
        /// The page size.
        /// </param>
        /// <returns>
        /// The <see cref="PagedList"/>.
        /// </returns>
        PagedList<T> FindEnties(int? pageIndex, int pageSize);

        /// <summary>
        /// The create entiy.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool CreateEntiy(T t);

        /// <summary>
        /// The get entiy.
        /// </summary>
        /// <param name="_id">
        /// The _id.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T GetEntiy(int _id);

        /// <summary>
        /// The del entiy.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool DelEntiy(T t);

        /// <summary>
        /// The update entiy.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool UpdateEntiy(T t);
        #endregion
    }
}

