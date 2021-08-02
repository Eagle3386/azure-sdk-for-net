// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkWatcher and their operations over a ResourceGroup. </summary>
    public partial class NetworkWatcherContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="NetworkWatcherContainer"/> class for mocking. </summary>
        protected NetworkWatcherContainer()
        {
        }

        /// <summary> Initializes a new instance of NetworkWatcherContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NetworkWatcherContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private NetworkWatchersRestOperations _restClient => new NetworkWatchersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a network watcher in the specified resource group. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="parameters"> Parameters that define the network watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<NetworkWatcher> CreateOrUpdate(string networkWatcherName, NetworkWatcherData parameters, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(networkWatcherName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a network watcher in the specified resource group. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="parameters"> Parameters that define the network watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<NetworkWatcher>> CreateOrUpdateAsync(string networkWatcherName, NetworkWatcherData parameters, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(networkWatcherName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a network watcher in the specified resource group. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="parameters"> Parameters that define the network watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NetworkWatchersCreateOrUpdateOperation StartCreateOrUpdate(string networkWatcherName, NetworkWatcherData parameters, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, networkWatcherName, parameters, cancellationToken);
                return new NetworkWatchersCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a network watcher in the specified resource group. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="parameters"> Parameters that define the network watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NetworkWatchersCreateOrUpdateOperation> StartCreateOrUpdateAsync(string networkWatcherName, NetworkWatcherData parameters, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, networkWatcherName, parameters, cancellationToken).ConfigureAwait(false);
                return new NetworkWatchersCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<NetworkWatcher> Get(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.Get");
            scope.Start();
            try
            {
                if (networkWatcherName == null)
                {
                    throw new ArgumentNullException(nameof(networkWatcherName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkWatcher(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<NetworkWatcher>> GetAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.Get");
            scope.Start();
            try
            {
                if (networkWatcherName == null)
                {
                    throw new ArgumentNullException(nameof(networkWatcherName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkWatcher(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<NetworkWatcher> GetIfExists(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.GetIfExists");
            scope.Start();
            try
            {
                if (networkWatcherName == null)
                {
                    throw new ArgumentNullException(nameof(networkWatcherName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<NetworkWatcher>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkWatcher(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<NetworkWatcher>> GetIfExistsAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.GetIfExists");
            scope.Start();
            try
            {
                if (networkWatcherName == null)
                {
                    throw new ArgumentNullException(nameof(networkWatcherName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<NetworkWatcher>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkWatcher(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (networkWatcherName == null)
                {
                    throw new ArgumentNullException(nameof(networkWatcherName));
                }

                var response = GetIfExists(networkWatcherName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (networkWatcherName == null)
                {
                    throw new ArgumentNullException(nameof(networkWatcherName));
                }

                var response = await GetIfExistsAsync(networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all network watchers by resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkWatcher" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<NetworkWatcher> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkWatcher> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkWatcher(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets all network watchers by resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkWatcher" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<NetworkWatcher> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkWatcher>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkWatcher(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="NetworkWatcher" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NetworkWatcherOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="NetworkWatcher" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NetworkWatcherOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, NetworkWatcher, NetworkWatcherData> Construct() { }
    }
}
