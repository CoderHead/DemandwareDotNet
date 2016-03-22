﻿using System.Collections.Generic;
using Net.Demandware.Ocapi.Shop.Models;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents a result containing an array of notes.
    /// </summary>
    /// <remarks>Contains notes for an object - for example, for a basket.</remarks>
    public sealed class NotesResult
    {
        #region Properties

        /// <summary>
        /// The notes for an object.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public IEnumerable<Note> Notes { get; set; }

        #endregion
    }
}
