// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Base class for restore request. Workload-specific restore requests are
    /// derived from this class.
    /// </summary>
    public partial class RestoreRequestResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RestoreRequestResource class.
        /// </summary>
        public RestoreRequestResource() { }

        /// <summary>
        /// Initializes a new instance of the RestoreRequestResource class.
        /// </summary>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="eTag">Optional ETag.</param>
        public RestoreRequestResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string eTag = default(string), RestoreRequest properties = default(RestoreRequest))
            : base(id, name, type, location, tags, eTag)
        {
            Properties = properties;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public RestoreRequest Properties { get; set; }

    }
}
