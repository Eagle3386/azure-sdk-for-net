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
    /// <summary> A class representing collection of HubVirtualNetworkConnection and their operations over a VirtualHub. </summary>
    public partial class HubVirtualNetworkConnectionContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="HubVirtualNetworkConnectionContainer"/> class for mocking. </summary>
        protected HubVirtualNetworkConnectionContainer()
        {
        }

        /// <summary> Initializes a new instance of HubVirtualNetworkConnectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal HubVirtualNetworkConnectionContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private HubVirtualNetworkConnectionsRestOperations _restClient => new HubVirtualNetworkConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualHubOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="hubVirtualNetworkConnectionParameters"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="hubVirtualNetworkConnectionParameters"/> is null. </exception>
        public virtual Response<HubVirtualNetworkConnection> CreateOrUpdate(string connectionName, HubVirtualNetworkConnectionData hubVirtualNetworkConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (hubVirtualNetworkConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(hubVirtualNetworkConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(connectionName, hubVirtualNetworkConnectionParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="hubVirtualNetworkConnectionParameters"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="hubVirtualNetworkConnectionParameters"/> is null. </exception>
        public async virtual Task<Response<HubVirtualNetworkConnection>> CreateOrUpdateAsync(string connectionName, HubVirtualNetworkConnectionData hubVirtualNetworkConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (hubVirtualNetworkConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(hubVirtualNetworkConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(connectionName, hubVirtualNetworkConnectionParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="hubVirtualNetworkConnectionParameters"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="hubVirtualNetworkConnectionParameters"/> is null. </exception>
        public virtual HubVirtualNetworkConnectionsCreateOrUpdateOperation StartCreateOrUpdate(string connectionName, HubVirtualNetworkConnectionData hubVirtualNetworkConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (hubVirtualNetworkConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(hubVirtualNetworkConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters, cancellationToken);
                return new HubVirtualNetworkConnectionsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="hubVirtualNetworkConnectionParameters"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="hubVirtualNetworkConnectionParameters"/> is null. </exception>
        public async virtual Task<HubVirtualNetworkConnectionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string connectionName, HubVirtualNetworkConnectionData hubVirtualNetworkConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (hubVirtualNetworkConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(hubVirtualNetworkConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters, cancellationToken).ConfigureAwait(false);
                return new HubVirtualNetworkConnectionsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<HubVirtualNetworkConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.Get");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubVirtualNetworkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<HubVirtualNetworkConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.Get");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HubVirtualNetworkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<HubVirtualNetworkConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<HubVirtualNetworkConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new HubVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<HubVirtualNetworkConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<HubVirtualNetworkConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new HubVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of all HubVirtualNetworkConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<HubVirtualNetworkConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HubVirtualNetworkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HubVirtualNetworkConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves the details of all HubVirtualNetworkConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<HubVirtualNetworkConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HubVirtualNetworkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HubVirtualNetworkConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="HubVirtualNetworkConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(HubVirtualNetworkConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="HubVirtualNetworkConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(HubVirtualNetworkConnectionOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, HubVirtualNetworkConnection, HubVirtualNetworkConnectionData> Construct() { }
    }
}
