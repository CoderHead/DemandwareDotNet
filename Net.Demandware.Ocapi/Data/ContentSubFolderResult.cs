﻿using System.Collections.Generic;
using Net.Demandware.Ocapi.BaseModels;
using Net.Demandware.Ocapi.BaseResults;
using Net.Demandware.Ocapi.Data.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Data
{
    /// <summary>
    /// Represents a result containing an array of content subfolders.
    /// </summary>
    public sealed class ContentSubFolderResult : BasePagedResult<ContentFolder>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. This array can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<ContentFolder> Data { get; set; }

        /// <summary>
        /// The fields that you want to select.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        #endregion
    }
}
