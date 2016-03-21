﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.BaseModels
{
    public abstract class BaseClass
    {
        #region Properties

        [JsonProperty(PropertyName = "id", Required = Required.DisallowNull)]
        [StringLength(100, MinimumLength = 1)]
        public virtual string Id { get; set; }

        [JsonProperty(PropertyName = "_type", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Type { get; set; }

        #endregion
    }
}
