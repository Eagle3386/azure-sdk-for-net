// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ExtendedLocations;

namespace Azure.ResourceManager.ExtendedLocations.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableExtendedLocationsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableExtendedLocationsResourceGroupResource"/> class for mocking. </summary>
        protected MockableExtendedLocationsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableExtendedLocationsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableExtendedLocationsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CustomLocationResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of CustomLocationResources and their operations over a CustomLocationResource. </returns>
        public virtual CustomLocationCollection GetCustomLocations()
        {
            return GetCachedClient(client => new CustomLocationCollection(client, Id));
        }

        /// <summary>
        /// Gets the details of the customLocation with a specified resource group and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CustomLocationResource>> GetCustomLocationAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetCustomLocations().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the customLocation with a specified resource group and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CustomLocationResource> GetCustomLocation(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetCustomLocations().Get(resourceName, cancellationToken);
        }
    }
}
