// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters for updating a container registry.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class RegistryUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RegistryUpdateParameters class.
        /// </summary>
        public RegistryUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the RegistryUpdateParameters class.
        /// </summary>
        /// <param name="tags">The resource tags for the container
        /// registry.</param>
        /// <param name="adminUserEnabled">The value that indicates whether
        /// the admin user is enabled. This value is false by default.</param>
        /// <param name="storageAccount">The properties of a storage account
        /// for the container registry. If specified, the storage account
        /// must be in the same physical location as the container
        /// registry.</param>
        public RegistryUpdateParameters(System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), bool? adminUserEnabled = default(bool?), StorageAccountProperties storageAccount = default(StorageAccountProperties))
        {
            Tags = tags;
            AdminUserEnabled = adminUserEnabled;
            StorageAccount = storageAccount;
        }

        /// <summary>
        /// Gets or sets the resource tags for the container registry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the value that indicates whether the admin user is
        /// enabled. This value is false by default.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.adminUserEnabled")]
        public bool? AdminUserEnabled { get; set; }

        /// <summary>
        /// Gets or sets the properties of a storage account for the container
        /// registry. If specified, the storage account must be in the same
        /// physical location as the container registry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccount")]
        public StorageAccountProperties StorageAccount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.StorageAccount != null)
            {
                this.StorageAccount.Validate();
            }
        }
    }
}
