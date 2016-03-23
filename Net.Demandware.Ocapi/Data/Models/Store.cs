﻿using Net.Demandware.Ocapi.BaseModels;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data.Models
{
    /// <summary>
    /// Represents a store.
    /// </summary>
    public sealed class Store : BaseStore
    {
        #region Properties

        /// <summary>
        /// A URL that is used to get this instance.
        /// </summary>
        /// <remarks>The property is computed and cannot be changed.</remarks>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        #endregion
    }
}
