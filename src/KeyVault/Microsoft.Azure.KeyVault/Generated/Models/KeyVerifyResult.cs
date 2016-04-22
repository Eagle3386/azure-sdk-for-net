// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class KeyVerifyResult
    {
        /// <summary>
        /// Initializes a new instance of the KeyVerifyResult class.
        /// </summary>
        public KeyVerifyResult() { }

        /// <summary>
        /// Initializes a new instance of the KeyVerifyResult class.
        /// </summary>
        public KeyVerifyResult(bool? value = default(bool?))
        {
            Value = value;
        }

        /// <summary>
        /// true if the signature is verified, false otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public bool? Value { get; private set; }

    }
}
