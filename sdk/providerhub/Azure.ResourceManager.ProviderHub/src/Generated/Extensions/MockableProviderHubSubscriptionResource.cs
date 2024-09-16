// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableProviderHubSubscriptionResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableProviderHubSubscriptionResource"/> class for mocking. </summary>
        protected MockableProviderHubSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableProviderHubSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableProviderHubSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ProviderRegistrationResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of ProviderRegistrationResources and their operations over a ProviderRegistrationResource. </returns>
        public virtual ProviderRegistrationCollection GetProviderRegistrations()
        {
            return GetCachedClient(client => new ProviderRegistrationCollection(client, Id));
        }

        /// <summary>
        /// Gets the provider registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ProviderRegistrationResource>> GetProviderRegistrationAsync(string providerNamespace, CancellationToken cancellationToken = default)
        {
            return await GetProviderRegistrations().GetAsync(providerNamespace, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the provider registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProviderRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ProviderRegistrationResource> GetProviderRegistration(string providerNamespace, CancellationToken cancellationToken = default)
        {
            return GetProviderRegistrations().Get(providerNamespace, cancellationToken);
        }
    }
}
