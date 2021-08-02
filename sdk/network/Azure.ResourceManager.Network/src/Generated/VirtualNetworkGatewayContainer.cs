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
    /// <summary> A class representing collection of VirtualNetworkGateway and their operations over a ResourceGroup. </summary>
    public partial class VirtualNetworkGatewayContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayContainer"/> class for mocking. </summary>
        protected VirtualNetworkGatewayContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkGatewayContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualNetworkGatewaysRestOperations _restClient => new VirtualNetworkGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a virtual network gateway in the specified resource group. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="parameters"> Parameters supplied to create or update virtual network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<VirtualNetworkGateway> CreateOrUpdate(string virtualNetworkGatewayName, VirtualNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(virtualNetworkGatewayName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a virtual network gateway in the specified resource group. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="parameters"> Parameters supplied to create or update virtual network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGateway>> CreateOrUpdateAsync(string virtualNetworkGatewayName, VirtualNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(virtualNetworkGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a virtual network gateway in the specified resource group. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="parameters"> Parameters supplied to create or update virtual network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkGatewaysCreateOrUpdateOperation StartCreateOrUpdate(string virtualNetworkGatewayName, VirtualNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, virtualNetworkGatewayName, parameters, cancellationToken);
                return new VirtualNetworkGatewaysCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, virtualNetworkGatewayName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a virtual network gateway in the specified resource group. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="parameters"> Parameters supplied to create or update virtual network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkGatewaysCreateOrUpdateOperation> StartCreateOrUpdateAsync(string virtualNetworkGatewayName, VirtualNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, virtualNetworkGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewaysCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, virtualNetworkGatewayName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualNetworkGateway> Get(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.Get");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualNetworkGateway>> GetAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.Get");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualNetworkGateway> GetIfExists(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualNetworkGateway>> GetIfExistsAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
                }

                var response = GetIfExists(virtualNetworkGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
                }

                var response = await GetIfExistsAsync(virtualNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all virtual network gateways by resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGateway" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualNetworkGateway> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all virtual network gateways by resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGateway" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualNetworkGateway> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGatewayOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGatewayOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, VirtualNetworkGateway, VirtualNetworkGatewayData> Construct() { }
    }
}
