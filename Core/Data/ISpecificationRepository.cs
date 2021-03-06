﻿namespace Core.Data
{
    using Core.Design;
    using System.Collections.Generic;

    /// <summary>
    /// Represents the base contract for repositories that are able to query a data source by specification.
    /// </summary>
    /// <typeparam name="TModel">The underlying model type.</typeparam>
    public interface ISpecificationRepository<TModel> where TModel : class
    {
        /// <summary>
        /// Finds a single item in the data source by specification.
        /// </summary>
        /// <param name="specification">The specification for the item to find in the data source.</param>
        /// <returns>A single item from the data source that matches the specification.</returns>
        TModel FindSingleBySpecification(Specification<TModel> specification);

        /// <summary>
        /// Finds all items in the data source by specification.
        /// </summary>
        /// <param name="specification">The specification for the items to find in the data source.</param>
        /// <returns>All items from the data source that match the specification.</returns>
        IEnumerable<TModel> FindAllBySpecification(Specification<TModel> specification);
    }
}
