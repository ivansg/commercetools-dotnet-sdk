﻿using System.Collections.Generic;

using commercetools.Common;

using Newtonsoft.Json;

namespace commercetools.ProductProjections
{
    /// <summary>
    /// An implementation of PagedQueryResult that provides access to the 
    /// results as a List of ProductProjection objects.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api.html#paged-query-result"/>
    public class ProductProjectionQueryResult : PagedQueryResult
    {
        #region Properties

        [JsonProperty(PropertyName = "results")]
        public List<ProductProjection> Results { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public ProductProjectionQueryResult(dynamic data)
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.Results = Helper.GetListFromJsonArray<ProductProjection>(data.results);
        }

        #endregion
    }
}