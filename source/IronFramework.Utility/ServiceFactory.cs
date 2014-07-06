// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceFactory.cs" company="Megadotnet">
//   Copyright (c) 2010-2011 Petter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   ServiceFactory
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace IronFramework.Utility
{
    using System;
    using System.Configuration;
    using System.IO;

    /// <summary>
    /// Service Factory
    /// </summary>
    public class ServiceFactory : IServiceFactory
    {
        #region Constants and Fields

        /// <summary>
        /// The service locator.
        /// </summary>
     

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="ServiceFactory"/> class. 
        /// </summary>
        static ServiceFactory()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <typeparam name="T">
        /// type
        /// </typeparam>
        /// <returns>
        /// target type
        /// </returns>
        public T GetInstance<T>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <returns> target type</returns>
        public T GetInstance<T>(string key)
        {
            throw new NotImplementedException();
        }

        #endregion
    }


    /// <summary>
    /// Interface IServiceFactory
    /// </summary>
    /// TODO: Should refernece MEF Common service locator adapter
    interface IServiceFactory
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <typeparam name="T">
        /// type
        /// </typeparam>
        /// <returns>
        /// target type
        /// </returns>
        T GetInstance<T>();
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <returns> target type</returns>
        T GetInstance<T>(string key);
    }
}